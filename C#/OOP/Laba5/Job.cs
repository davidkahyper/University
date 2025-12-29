using System.Collections;

namespace Laba5
{
    /// <summary>
    /// Прием программистов на работу
    /// </summary>
    
    public class Job
    {
        /// <summary>
        /// Числов претендентов
        /// </summary>
        private int n;

        /// <summary>
        /// массивы, задающие свойства претендентов
        /// </summary>
        private Prog_Properties[] cand;
        private string[] strCand;
        private Prog_Properties pattern;

        private Prog_Properties currentScale;
        private Random rnd;

        /// <summary>
        /// Формирование свойств кандидатов
        /// Каждое свойство появляется с вероятностью 0.5
        /// </summary>
        public void FormCands()
        {
            int properties = 5;
            int p = 0, q = 0, currentProps = 0;
            string strQ = "";
            for (int i = 0; i < properties; i++)
            {
                currentProps = 0;
                strQ = "";
                for (int j = 0; j < properties; j++)
                {
                    p = rnd.Next(2);
                    q = (int)Math.Pow(2, j);
                    if (p == 1)
                    {
                        currentProps += q;
                        strQ += (Prog_Properties)q + ", ";
                    }
                }

                cand[i] = (Prog_Properties)currentProps;
                if (strQ != "")
                {
                    strCand[i] = strQ.Remove(strQ.Length - 2);
                }
                else strCand[i] = "";
            }
        }

        public string[] GetStrCands()
        {
            return strCand;
        }
        public Prog_Properties[] GetCands()
        {
            return cand;
        }

        /// <summary>
        /// Список кандидатов, которые обладают
        /// свойствами, заданных образцом.
        /// </summary>
        public ArrayList CandsHavePat()
        {
            ArrayList temp  = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                if ((cand[i] & pattern) == pattern)
                    temp.Add("cand[" + i + "]");
            }
            return temp;
        }

        /// <summary>
        /// Список кандидатов, которые не обладают
        /// всеми свойствами, заданных образцом.
        /// </summary>
        public ArrayList CandHaveNotAllPat()
        {
            ArrayList temp  = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                if ((~cand[i] & pattern) == pattern)
                    temp.Add("cand[" + i + "]");
            }
            return temp;
        }
        
        
        /// <summary>
        /// Список кандидатов, которые обладают
        /// некоторыми свойствами, заданных образцом.
        /// </summary>
        public ArrayList CandHaveSomePat()
        {
            ArrayList temp  = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                if (currentScale > 0 && currentScale < pattern)
                    temp.Add("cand[" + i + "]");
            }
            return temp;
        }
        
        /// <summary>
        /// Список кандидатов, которые обладают
        /// только свойствами, заданных образцом.
        /// </summary>
        public ArrayList CandHaveOnlyPat()
        {
            ArrayList temp  = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                if (((cand[i] & pattern) == pattern) && ((cand[i] & ~pattern) == 0))
                    temp.Add("cand[" + i + "]");
            }
            return temp;
        }
        

        public Job()
        {
            n = 10;
            cand = new Prog_Properties[n];
            strCand = new string[n];
            rnd = new Random(DateTime.Now.Millisecond);
        }

        public Job(int n)
        {
            this.n = n;
            cand = new Prog_Properties[n];
            strCand = new string[n];
            rnd = new Random(DateTime.Now.Millisecond);
        }

        public Job(Prog_Properties[] pp)
        {
            n = pp.Length;
            cand = pp;
            strCand = new string[n];
            rnd = new Random(DateTime.Now.Millisecond);
        }

        public Prog_Properties Pattern
        {
            set { pattern = value; }
        }
    }

    /// <summary>
    /// Свойства претендентов на должность программиста,
    /// описывающие знание технологий и языков программирований
    /// </summary>
    public enum Prog_Properties
    {
        VB = 1, C_Sharp = 2, C_plus_plus = 4, Web = 8, Prog_1C = 16
    }
}