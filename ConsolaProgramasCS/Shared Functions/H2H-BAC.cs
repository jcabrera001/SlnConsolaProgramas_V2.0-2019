using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using Renci.SshNet;

namespace ConsolaProgramasCS
{


    public class H2H_BAC
    {
        private String m_strErrorDes = "";

        //this is sftp client variable
        private SftpClient m_sftpClient = null;


        public H2H_BAC()
        {

        }

        //This function is used to upload a file using ftp Protocol
        public void UploadFTP(string Server, string Filename, string Username, string Password, string FullName)
        {
            //Uri oldUri = new Uri(string.Format("{0}/{1}", Server, Filename));
            //UriBuilder builder = new UriBuilder(oldUri);
            //builder.Port = 222;
            //Uri newUri = builder.Uri;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));
            ServicePointManager.ServerCertificateValidationCallback = (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(Username, Password);
            Stream ftpstream = request.GetRequestStream();
            FileStream fs = File.OpenRead(FullName);

            // Method to calculate and show the progress.
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                byteRead = fs.Read(buffer, 0, 1024);
                ftpstream.Write(buffer, 0, byteRead);
                read += (double)byteRead;
                double percentage = read / total * 100;
                //backgroundWorker1.ReportProgress((int)percentage);
            }
            while (byteRead != 0);
            fs.Close();
            ftpstream.Close();
        }

        //this is function using let connect to sftp server
        public bool connectSftpServer(String strHost, int iPort, String strUserName,
            String strPassword, int iTimeout)
        {
            bool blResult = false;

            try
            {
                this.m_strErrorDes = "";

                //create a new instance for sftp client variable
                this.m_sftpClient = new SftpClient(strHost, iPort, strUserName, strPassword);
                this.m_sftpClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(iTimeout);
                this.m_sftpClient.KeepAliveInterval = TimeSpan.FromSeconds(10);

                //connect to server
                this.m_sftpClient.Connect();
                blResult = true;
            }
            catch (Exception exp)
            {
                //return error let show for user
                this.m_strErrorDes = "SFTP_0000: ERROR - " + exp.Message;
            }
            return blResult;
        }

        public void UploadFTP(string path, DataTable dt)
        {

            foreach (DataRow row in dt.Rows)
            {

                this.m_sftpClient.AppendAllText(path, row["Row"].ToString());
            }


        }
        //function using upload file to sftp server
        public bool uploadFile(String strSource, String strDesPath, bool blOverride)
        {
            bool blResult = false;
            System.IO.FileStream fileStream = null;

            try
            {
                this.m_strErrorDes = "";

                //in here we will get stream of file from local dir
                fileStream = new System.IO.FileStream(strSource,
                    System.IO.FileMode.Open, System.IO.FileAccess.Read);

                this.m_sftpClient.UploadFile(fileStream, strDesPath, blOverride, null);
                //this.m_sftpClient.UploadFile(GenerateStreamFromString(strSource), strDesPath, blOverride, null);
               blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0001: ERROR - " + exp.Message;
            }
            finally
            {
                //after open file stream please close file stream let handle of file to be free
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return blResult;
        }

        //this function use to download file
        public bool downloadFile(String strSftpPath, String strLocalPath)
        {
            bool blResult = false;
            System.IO.FileStream fileStream = null;

            try
            {
                this.m_strErrorDes = "";
                //open new file in local dir
                fileStream = new System.IO.FileStream(strLocalPath, System.IO.FileMode.OpenOrCreate);

                //download file from sftp server
                this.m_sftpClient.DownloadFile(strSftpPath, fileStream, null);
                blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0002: ERROR - " + exp.Message;
            }
            finally
            {
                //closing stream
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return blResult;
        }

        //function use to delete file
        public bool deleteFile(String strFilePath)
        {
            bool blResult = false;

            try
            {
                this.m_strErrorDes = "";
                this.m_sftpClient.DeleteFile(strFilePath);
                blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0004: ERROR - " + exp.Message;
            }
            return blResult;
        }

        //rename file
        public bool renameFile(String strOldPathName, String strNewPathName)
        {
            bool blResult = false;

            try
            {
                this.m_strErrorDes = "";
                this.m_sftpClient.RenameFile(strOldPathName, strNewPathName);
                blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0005: ERROR - " + exp.Message;
            }
            return blResult;
        }

        //delete folder
        public bool deleteDirectory(String strFolderPath)
        {
            bool blResult = false;

            try
            {
                this.m_strErrorDes = "";
                this.m_sftpClient.DeleteDirectory(strFolderPath);
                blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0006: ERROR - " + exp.Message;
            }
            return blResult;
        }

        //creating a new folder
        public bool creatingDirectory(String strFolderPath)
        {
            bool blResult = false;

            try
            {
                this.m_strErrorDes = "";
                this.m_sftpClient.CreateDirectory(strFolderPath);
                blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0007: ERROR - " + exp.Message;
            }
            return blResult;
        }

        //creating text file
        public bool creatingText(String strFilePath)
        {
            bool blResult = false;

            try
            {
                this.m_strErrorDes = "";
                this.m_sftpClient.CreateText(strFilePath);
                blResult = true;
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0008: ERROR - " + exp.Message;
            }
            return blResult;
        }

        //list file from sftp server
        public IEnumerable<Renci.SshNet.Sftp.SftpFile> listFile(String strSftpPath)
        {
            IEnumerable<Renci.SshNet.Sftp.SftpFile> ienFileList = null;

            try
            {
                this.m_strErrorDes = "";
                ienFileList = this.m_sftpClient.ListDirectory(strSftpPath, null);
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = "SFTP_0003: ERROR - " + exp.Message;
            }
            return ienFileList;
        }

        //closing sftp client
        public void close()
        {
            try
            {
                if (this.m_sftpClient != null)
                {
                    this.m_sftpClient.Disconnect();
                }
            }
            catch (Exception exp)
            {
                this.m_strErrorDes = exp.Message;
            }
            this.m_sftpClient = null;
        }

        //get error when using function of sftp client
        public String getErrorDes()
        {
            return this.m_strErrorDes;
        }

    

    }
}
