using System.Windows.Forms;
using System.Threading;

namespace MSGBOX_Spam
{
    class Spamming_Class
    {
        static void Main()
        {
            Spamming_Class sc = new Spamming_Class();
            Thread thread = new Thread(sc.MSGBOXLAUNCH);
            thread.Start();
        }
        public void MSGBOX()
        {
            MessageBox.Show("Hey, I'm spamming you, so go subscribe to Ali Diaa's YouTube channel! <3", "Spammy Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MSGBOXLAUNCH()
        {
            while (true)
            {
                Thread MSGBOXT = new Thread(MSGBOX);
                MSGBOXT.Start();
                Thread.Sleep(10);
            }
        }
    }
}