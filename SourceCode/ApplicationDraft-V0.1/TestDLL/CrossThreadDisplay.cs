using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhDLL
{
    public class CrossThreadDisplay : IDisposable
    {
        Form myForm;
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public CrossThreadDisplay(Form f)
        {
            myForm = f;
        }

        // Delegates for cross-thread processing
        delegate void LabelDelegate(string text, Label lb);
        delegate void ListboxDelegate(Object o, ListBox lb);
        delegate void VoidListboxDelegate(ListBox lb);

        // Clearing the given listbox
        public void ClearListbox(ListBox lb)
        {
            if (lb.InvokeRequired)
            {
                VoidListboxDelegate d = new VoidListboxDelegate(ClearListbox);
                myForm.Invoke(d, new object[] { lb });
            }
            else
            {
                lb.Items.Clear();
            }
        }
        // Set text to label
        public void SetText(string text, Label lb)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (lb.InvokeRequired)
            {
                LabelDelegate d = new LabelDelegate(SetText);
                myForm.Invoke(d, new object[] { text, lb });
            }
            else
            {
                lb.Text = text;
            }
        }

        // Display an article in a given listbox
        public void DisplayLoanArticle(Object o, ListBox lb)
        {
            List<LoanArticle> list = (List<LoanArticle>)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayLoanArticle);
                myForm.Invoke(d, new object[] { list, lb });
            }
            else
            {
                lb.Items.Clear();
                foreach (LoanArticle a in list)
                {
                    lb.Items.Add(a);
                }
            }
        }

        // Display an article in a given listbox
        public void DisplayArticle(Object o, ListBox lb)
        {
            List<LoanArticle> list = (List<LoanArticle>)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayArticle);
                myForm.Invoke(d, new object[] { list, lb });
            }
            else
            {
                lb.Items.Clear();
                foreach (LoanArticle a in list)
                {
                    lb.Items.Add(a);
                }
            }
        }

        // Display a ticket in a given listbox
        public void DisplayTicket(Object o, ListBox lb)
        {
            Ticket t = (Ticket)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayTicket);
                myForm.Invoke(d, new object[] { t, lb });
            }
            else
            {
                // Display them info
                lb.Items.Clear();
                lb.Items.Add("TICKET #" + t.TicketNr);
                lb.Items.Add("Bought: " + t.TicketDate + " " + t.TicketTime);
                lb.Items.Add("Type: " + t.TicketType);
                lb.Items.Add("Status: " + (t.Paid ? "PAID" : "NOT PAID"));
            }
        }

        // Display a ticket in a given listbox
        public void DisplayReservation(Object o, ListBox lb)
        {
            Reservation r = (Reservation)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayTicket);
                myForm.Invoke(d, new object[] { r, lb });
            }
            else
            {
                // Display them info
                lb.Items.Clear();
                lb.Items.Add("RESERVATION #" + r.ReservNr);
                lb.Items.Add("Reserved: " + r.ReservDate + " " + r.ReservTime);
                lb.Items.Add("Reserver: " + r.Reserver.FirstName + ", " + r.Reserver.LastName);
                lb.Items.Add("Spot: Spot #" + r.Spot.SpotNr + " - " + r.Spot.SpotName);
                lb.Items.Add("Number of people: " + r.NrCheckedIn + "/" + r.NrOfRegistered);
                lb.Items.Add("Period: " + r.StartDate + " - " + r.EndDate);
                lb.Items.Add("Status: " + (r.Paid ? "PAID" : "NOT PAID"));
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }

        ~CrossThreadDisplay()
        {
            Dispose(false);
        }
    }
}
