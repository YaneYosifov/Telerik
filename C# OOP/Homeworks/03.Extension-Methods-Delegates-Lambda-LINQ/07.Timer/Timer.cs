/* Problem 7. Timer
 * Using delegates write a class Timer that can execute certain method at each t seconds.
 */

namespace Timer
{
    using System.Timers;
    using System.Threading;
    class Timer
    {
        public int Seconds { get; private set; }
        public delegate void TimerDlg(string param);
        private TimerDlg InputMethod;

        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        public TimerDlg Method
        {
            get { return this.InputMethod; }
            set { this.InputMethod = value; }
        }

        public void Start(string inputVal)
        {
            while (true)
            {
                InputMethod(inputVal);
                Thread.Sleep(Seconds * 1000);
            }
        }
    }
}
