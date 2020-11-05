using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaCircularDinamica
{
    class Cola
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        private Nodo tail;

        public Nodo Tail
        {
            get { return head; }
            set { head = value; }
        }
        public Cola()
        {
            head = null;
            tail = null;
        }

        public void Encolar(Nodo n)
        {
            if (head == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.Siguiente = n;
                tail = n;
                tail.Siguiente = head;
            }
        }
        public void Desencolar()
        {
            if (head == null)
            {
                return;
            }
            if (head.Siguiente == head)
            {
                head = null;
                tail = null;
            }
            head = head.Siguiente;
            tail.Siguiente = head;
        }
        public int Front()
        {
            return head.Dato;
        }
        public override string ToString()
        {
            string stringCola = "";
            Nodo h = head;
            if (h != null)
            {
                if (h.Siguiente != h)
                {
                    while (h != tail)
                    {
                        stringCola += "," + h.ToString();
                        h = h.Siguiente;
                    }
                    stringCola += "," + h.ToString();
                    return stringCola;
                }
                else
                {
                    stringCola += h.ToString();
                    return stringCola;
                }

            }
            else
            {
                return "Cola vacia";
            }
           
        }
    }
}
