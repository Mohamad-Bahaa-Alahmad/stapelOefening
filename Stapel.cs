using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StapelOefening
{
    internal class Stapel<T>
    {
        
       private List<T> stapel = new List<T>();
       private List<T> kopie = new List<T>();
        int teller = -1;
        public Stapel()
        {

        }
        public void OpStapel(T f)
        {
            
            teller++;
            stapel.Add(f);
            
            
        }
        public void VanStapel()
        {
            if (teller >= 0)
            {
                stapel.RemoveAt(stapel.Count - 1);
                teller--;
            }
            
           
            
        }

        public Boolean ZitIn(T Iets)
        {
            Boolean result = false;
            foreach (T i in stapel)
            {
                string text = Iets.ToString();
                string text1 = i.ToString();
                if(text == text1)
                {
                    result = true;
                }
            }
            
            return result;

        }
        public void Leegmaken()
        {
            stapel.Clear();
        }
        public void Kopieer()
        {
            foreach (T i in stapel)
            {
                kopie.Add(i);
            }
        }
        
        public void terugzet()
        {
            stapel.Clear();
            foreach (T i in kopie)
            {
                stapel.Add(i);
            }
        }
        public override string ToString()
        {
            string content = "";
            foreach (T i in stapel)
                content += i + "; ";
            return content;
        }
        public string Copy()
        {
            string content = "";
            foreach (T i in kopie)
                content += i + "; ";
            return content;
        }
    }
}
