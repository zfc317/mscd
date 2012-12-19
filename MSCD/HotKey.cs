using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MSCD.UI
{
    public class HotKey
    {
        //�������ִ�гɹ�������ֵ��Ϊ0��
        //�������ִ��ʧ�ܣ�����ֵΪ0��Ҫ�õ���չ������Ϣ������GetLastError��
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
            IntPtr hWnd,                //Ҫ�����ȼ��Ĵ��ڵľ��
            int id,                     //�����ȼ�ID������������ID�ظ���           
            KeyModifiers fsModifiers,   //��ʶ�ȼ��Ƿ��ڰ�Alt��Ctrl��Shift��Windows�ȼ�ʱ�Ż���Ч
            Keys vk                     //�����ȼ�������
            );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,                //Ҫȡ���ȼ��Ĵ��ڵľ��
            int id                      //Ҫȡ���ȼ���ID
            );

        //�����˸����������ƣ�������ת��Ϊ�ַ��Ա��ڼ��䣬Ҳ��ȥ����ö�ٶ�ֱ��ʹ����ֵ��
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
    }
}
