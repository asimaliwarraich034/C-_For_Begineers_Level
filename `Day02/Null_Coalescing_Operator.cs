

namespace Introductio_To_CSharp._Day02
{
     class Null_Coalescing_Operator
    {
        static void Main()
        {
           int ? TicketsOnSale = null;
           // int? TicketsOnSale = 100;
            /*  int AvailableTickets;

              if (TicketsOnSale == null)
              {
                  AvailableTickets = 0;
              } else
              {
                  AvailableTickets = (int)TicketsOnSale; // Enforcing Nullable data type to Non-Nullable
              } */
            // Null Coalescing Operator 

            int AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("Available Ticket = {0} " , AvailableTickets);
        }
    }
}
