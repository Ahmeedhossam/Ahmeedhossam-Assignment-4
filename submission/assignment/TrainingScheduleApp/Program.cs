using System;
using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

string[] namesOfSessions =
{
"C# Basics",
"Arrays",
"Functions",
"Date and Time",
"Exception Handling"
};
DateTime[] sessionDates =
{
new DateTime(2026, 9, 10, 18, 0, 0),
new DateTime(2026, 9, 13, 18, 0, 0),
new DateTime(2026, 9, 17, 18, 0, 0),
new DateTime(2026, 9, 20, 18, 0, 0),
new DateTime(2026, 9, 24, 18, 0, 0)
};
int[] sessionDurations =
{
180,
240,
180,
240,
180
};
//FindSessionIndex(namesOfSessions);

//DisplayAllSessions(namesOfSessions, sessionDates, sessionDurations);
FindSessionIndex(namesOfSessions);

void DisplayAllSessions(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
{
    for (int i = 0; i < sessionNames.Length; i++)

        Console.WriteLine($"{i + 1} {sessionNames[i]} \n\n Date : {sessionDates[i].ToString("dd MMMM yyyy")} \n start time {sessionDates[i].ToString("hh:mm tt")} \n Duration : {sessionDurations[i]} \n  ");
}

void SearchForSession(string sessionName, string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
{
    int containName = Array.FindIndex(sessionNames, x => x.Equals(sessionName, StringComparison.OrdinalIgnoreCase));

    if (containName == -1)
    {
        Console.WriteLine($"{sessionName} is not found ");
    }
    else
    {
        Console.WriteLine($"{sessionNames[containName]} \n\n Date : {sessionDates[containName].ToString("dd MMMM yyyy")} \n start time {sessionDates[containName].ToString("hh:mm tt")} \n Duration : {sessionDurations[containName]} \n  ");
    }
}

void SortSessionNames(string[] sessionNames)
{
    string[] namesOfSessions = new string[sessionNames.Length];

    Array.Copy(sessionNames, namesOfSessions, namesOfSessions.Length);

    Array.Sort(namesOfSessions);

    for (int i = 0; i < namesOfSessions.Length; i++)
    {
        Console.WriteLine($"{i + 1} {namesOfSessions[i]}");
    }
}
void ReverseSessionNames(string[] sessionNames)
{
    string[] namesOfSessions = new string[sessionNames.Length];

    Array.Copy(sessionNames, namesOfSessions, namesOfSessions.Length);

    Array.Reverse(namesOfSessions);

    for (int i = 0; i < namesOfSessions.Length; i++)
    {
        Console.WriteLine($"{i + 1} {namesOfSessions[i]}");
    }
}

void FindSessionIndex(string[] sessionName)
{
    Console.WriteLine("Enter session name :");
    string session = Console.ReadLine();

    int index = Array.IndexOf(sessionName, session);

    if (index != -1)
    {
        Console.WriteLine($"Index: {index}");
    }
    else
    {
        Console.WriteLine("Session not found.");
    }
}
void SessionExists(string[] sessionName)
{
    Console.WriteLine("Enter session name :");

    string session = Console.ReadLine();

    if (Array.Exists(sessionName, s => s.Equals(session, StringComparison.OrdinalIgnoreCase)))
    {
        Console.WriteLine("Session exists");
    }
    else
        Console.WriteLine("Session does not exists");
}

void FindSession(string[] sessionName)
{
    string session = Array.Find(sessionName, name => name.Length >= 7);

    if (session != null)
    {
        Console.WriteLine(session);
    }
    else
    {
        Console.WriteLine("No session matches the condition.");
    }
}

void FindSessionIndex2(string[] sessionName)
{
    int sessionIndex = Array.FindIndex(sessionName, name => name.Length >= 7);

    if (sessionIndex != -1)
    {
        Console.WriteLine(sessionIndex);
    }
    else
    {
        Console.WriteLine("No session matches the condition.");
    }
}

void CopySessionName(string[] sessionNames)
{
    string[] copyIntoArray = new string[sessionNames.Length];
    Array.Copy(sessionNames, copyIntoArray, copyIntoArray.Length);

    copyIntoArray[1] = "Modified Session";

    Console.WriteLine("--- Copied Array ---");
    for (int i = 0; i < copyIntoArray.Length; i++)
    {
        Console.WriteLine(copyIntoArray[i]);
    }

    Console.WriteLine("\n--- Original Array ---");
    for (int i = 0; i < sessionNames.Length; i++)
    {
        Console.WriteLine(sessionNames[i]);
    }
}

int CalculateTotalDuration(int[] sessionsDuration)
{
    int totalDuration = 0;
    for (int i = 0; i < sessionsDuration.Length; i++)
    {
        totalDuration += sessionsDuration[i];
    }
    Console.WriteLine($"Total Duration : {totalDuration}");
    return totalDuration;
}

int CalculateLongestDuration(int[] sessionsDuration)
{
    int max = sessionsDuration[0];
    for (int i = 1; i < sessionsDuration.Length; i++)
    {
        if (sessionsDuration[i] > max)
        {
            max = sessionsDuration[i];
        }
    }
    Console.WriteLine($"Longest Duration: {max} minutes");
    return max;
}

int CalculateShortestDuration(int[] sessionsDuration)
{
    int min = sessionsDuration[0];
    for (int i = 1; i < sessionsDuration.Length; i++)
    {
        if (sessionsDuration[i] < min)
        {
            min = sessionsDuration[i];
        }
    }
    Console.WriteLine($"Shortest Duration: {min} minutes");
    return min;
}

double CalculateAverageDuration(int[] sessionsDuration)
{
    double sum = 0;
    for (int i = 0; i < sessionsDuration.Length; i++)
    {
        sum += sessionsDuration[i];
    }
    double average = sum / sessionsDuration.Length;
    Console.WriteLine($"Average Duration: {average} minutes");
    return average;
}
void SortAndDisplayDurations(int[] sessionDurations)
{
    int[] sortedDurations = new int[sessionDurations.Length];
    Array.Copy(sessionDurations, sortedDurations, sortedDurations.Length);
    Array.Sort(sortedDurations);

    Console.WriteLine("Sorted Durations:");
    for (int i = 0; i < sortedDurations.Length; i++)
    {
        Console.WriteLine($"{sortedDurations[i]} minutes");
    }
}

void AddMinutesToSessionDuration(ref int duration)
{
    Console.WriteLine("Enter minutes you want to add to the session duration");
    int minutes = Convert.ToInt32(Console.ReadLine());
    duration += minutes;
}

bool TryGetSessionDetails(string sessionName, string[] names, int[] durations, out int index, out int duration)
{
    int indexx = Array.IndexOf(names, sessionName);

    if (indexx == -1)
    {
        index = indexx;
        duration = 0;

        return false;
    }
    else
    {
        index = indexx;
        duration = durations[indexx];

        Console.WriteLine($"index : {index}");
        Console.WriteLine($"duration : {duration}");

        return true;
    }
}
void ReferenceTypeWithoutRef(string[] names)
{
    names[0] = "Advanced C#";
}

int CalculateTotalDuration2(params int[] sessionDurations)
{
    int totalDuration = 0;
    for (int i = 0; i < sessionDurations.Length; i++)
    {
        totalDuration += sessionDurations[i];
    }
    return totalDuration;
}

void DisplaySessionDateDetails(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
{
    Console.WriteLine("Enter session name:");
    string sessionName = Console.ReadLine();

    int index = Array.FindIndex(sessionNames, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));

    if (index == -1)
    {
        Console.WriteLine("Session not found.");
        return;
    }

    DateTime date = sessionDates[index];
    int duration = sessionDurations[index];
    DateTime endTime = date.AddMinutes(duration);

    Console.WriteLine($"Session: {sessionNames[index]}");
    Console.WriteLine($"Date: {date.ToString("dd MMMM yyyy")}");
    Console.WriteLine($"Day: {date.DayOfWeek}");
    Console.WriteLine($"Year: {date.Year}");
    Console.WriteLine($"Month: {date.Month}");
    Console.WriteLine($"Day Number: {date.Day}");
    Console.WriteLine($"Start Time: {date.ToString("hh:mm tt")}");
    Console.WriteLine($"Duration: {duration} minutes");
    Console.WriteLine($"End Time: {endTime.ToString("hh:mm tt")}");
}