using System;

class Program
{
    static void Main(string[] args)
    {
        LecturesEvent lecturesEvent = new LecturesEvent("Peruvian Literature.","Mario Vargas Llosa", 150, "July 30", "6:00 pm", "We will learn about the books of a Peruvian author.");
        lecturesEvent.SetAddress("11834 Harry Hines Boulevard", "Dallas", "Texas", "USA");
        lecturesEvent.DisplayStandarDetails();
        lecturesEvent.DisplayFullDetails();
        lecturesEvent.DisplayShortDescription();

        RecepetionEvent recepetionEvent = new RecepetionEvent("Mothers Day Dinner.", "Peter.dinners@recpetions.com", "May 10","10:00 A.m.","For all the mothers who want to have a nice party to celebrate Mother's Day." );
        recepetionEvent.SetAddress("3165 darvany Dr", "Dallas", "Texas", "USA");
        recepetionEvent.DisplayStandarDetails();
        recepetionEvent.DisplayFullDetails();
        recepetionEvent.DisplayShortDescription();

        OutdoorGateringEvent outdoorGateringEvent = new OutdoorGateringEvent("John and Maria's wedding.", "April 25","9:00 A.m.","Join us to celebrate the wedding of John and Maria who with a lot of love decided to unite their lives.", "Sunny.");
        outdoorGateringEvent.SetAddress("3254 South Buckner Blvd", "Dallas", "Texas", "USA");
        outdoorGateringEvent.DisplayStandarDetails();
        outdoorGateringEvent.DisplayFullDetails();
        outdoorGateringEvent.DisplayShortDescription();




    }
}