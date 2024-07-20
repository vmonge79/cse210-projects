using System;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("Tres Ríos", "Cartago");
        Address ad2 = new Address("San Joaquín", "Heredia");
        Address ad3 = new Address("San Pedro", "San José");
        Address ad4 = new Address("San Carlos", "Alajuela");


        Lecture lec1 = new Lecture("Mindfulness Applied to Therapy", "Learn very practical techniques based on mindfulness to support your patients in their therapeutic processes.", ad1, "Viviana Monge", 25, "November 4th, 2024", "10:00am");

        Lecture lec2 = new Lecture("High Performance Teams", "Learn actionable strategies and tools to empower high-performance teams in achieving their objectives and enhancing overall effectiveness.", ad4, "Viviana Monge", 100, "October 12th, 2024", "09:00am");

        Reception rec1 = new Reception("Product Launch", "Event for P&Gs clients to launch all the new products and marketing strategies for those.", ad1, "Please confirm 2 days before the date of teh event.", "September 04th, 2024", "05:30pm");

        Reception rec2 = new Reception("Fashion Week", "Fashion event where the top designer brands will showcase their best designs with the latest trends.", ad3, "Please confirm before August 15th", "August 30th, 2024", "07:00pm");

        Outdoor out1 = new Outdoor("Chirripo Hike", "Dare to immerse yourself in the forests of Costa Rica and climb the highest mountain in a 3-day adventure.", ad2, "Rainy days", "Aug13th-Aug16th 2024", "04:00am");

        Outdoor out2 = new Outdoor("State Fair", "Participate in the largest fair in Central America.", ad1, "Sunny days", "Jan10th-Feb-15th 2025", "09:00am-10:00pm");

        List<Event> _events = new List<Event> { lec1, lec2, rec1, rec2, out1, out2 };

        foreach (Event e in _events)
        {
            e.DisplayDetails();
        }

        foreach (Event e in _events)
        {
            e.DisplayFullDetails();
        }

        foreach (Event e in _events)
        {
            e.DisplayShortDescription();
        }
    }
}
