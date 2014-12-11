using System;
using System.Text;
using Wintellect.PowerCollections;

public static class Messages
{
    public static readonly StringBuilder Output = new StringBuilder();

    public static void EventAdded()
    {
        Output.Append("Event added" + System.Environment.NewLine);
    }

    public static void EventDeleted(int amount)
    {
        if (amount == 0)
        {
            NoEventsFound();
        }
        else
        {
            Output.AppendFormat("{0} events deleted" + System.Environment.NewLine, amount);
        }
    }

    public static void NoEventsFound()
    {
        Output.Append("No events found" + System.Environment.NewLine);
    }

    public static void PrintEvent(Event eventToPrint)
    {
        if (eventToPrint != null)
        {
            Output.Append(eventToPrint + System.Environment.NewLine);
        }
    }
}

public class Event : IComparable
{
    public Event(DateTime date, string title, string location)
    {
        this.Date = date;
        this.Title = title;
        this.Location = location;
    }

    public DateTime Date { get; set; }

    public string Title { get; set; }

    public string Location { get; set; }

    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int byDate = this.Date.CompareTo(other.Date);
        int byTitle = this.Title.CompareTo(other.Title);
        int byLocation = this.Location.CompareTo(other.Location);

        if (byDate == 0)
        {
            if (byTitle == 0)
            {
                return byLocation;
            }
            else
            {
                return byTitle;
            }
        }
        else
        {
            return byDate;
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
        result.Append(" | " + this.Title);

        if (this.Location != null && this.Location != string.Empty)
        {
            result.Append(" | " + this.Location);
        }

        return result.ToString();
    }
}

public class EventHolder
{
    private readonly MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);
    private readonly OrderedBag<Event> byDate = new OrderedBag<Event>();

    public void AddEvent(DateTime date, string title, string location)
    {
        Event newEvent = new Event(date, title, location);
        this.byTitle.Add(title.ToLower(), newEvent);
        this.byDate.Add(newEvent);
        Messages.EventAdded();
    }

    public void DeleteEvents(string titleToDelete)
    {
        string title = titleToDelete.ToLower();
        int removed = 0;

        foreach (var eventToRemove in this.byTitle[title])
        {
            removed++;
            this.byDate.Remove(eventToRemove);
        }

        this.byTitle.Remove(title);
        Messages.EventDeleted(removed);
    }

    public void ListEvents(DateTime date, int count)
    {
        OrderedBag<Event>.View eventsToShow = this.byDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
        int shown = 0;

        foreach (var eventToShow in eventsToShow)
        {
            if (shown == count)
            {
                break;
            }

            Messages.PrintEvent(eventToShow);
            shown++;
        }

        if (shown == 0)
        {
            Messages.NoEventsFound();
        }
    }
}

public class Program
{
    private static readonly EventHolder Events = new EventHolder();

    public static void Main(string[] args)
    {
        while (ExecuteNextCommand())
        {
        }

        Console.WriteLine(Messages.Output);
    }

    private static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();
        char fristLetter = command[0];

        if (fristLetter == 'A')
        {
            AddEvent(command);
            return true;
        }

        if (fristLetter == 'D')
        {
            DeleteEvents(command);
            return true;
        }

        if (fristLetter == 'L')
        {
            ListEvents(command);
            return true;
        }

        if (fristLetter == 'E')
        {
            return false;
        }

        return false;
    }

    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');

        DateTime date = GetDate(command, "ListEvents");

        string countString = command.Substring(pipeIndex + 1);
        int count = int.Parse(countString);

        Events.ListEvents(date, count);
    }

    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);
        Events.DeleteEvents(title);
    }

    private static void AddEvent(string command)
    {
        DateTime date;
        string title;
        string location;

        GetParameters(command, "AddEvent", out date, out title, out location);
        Events.AddEvent(date, title, location);
    }

    private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);

        int firstPipeIndex = commandForExecution.IndexOf('|');
        int lastPipeIndex = commandForExecution.LastIndexOf('|');

        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = string.Empty;
        }
        else
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }

    private static DateTime GetDate(string command, string commandType)
    {
        DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 19));
        return date;
    }
}