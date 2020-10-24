using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            bool containsLessonTitle = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="course start")
                {
                    break;
                }

                List<string> command = input.Split(":").ToList();

                if (command[0] == "Add")
                {
                    string lessonTitle = command[1];

                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == lessonTitle)
                        {
                            containsLessonTitle = true;
                            break;
                        }
                    }
                    if (!containsLessonTitle)
                    {
                        schedule.Add(lessonTitle);
                    }
                    containsLessonTitle = false;
                }
                else if (command[0] == "Insert")
                {
                    string lessonTitle = command[1];
                    int index = int.Parse(command[2]);

                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == lessonTitle)
                        {
                            containsLessonTitle = true;
                            break;
                        }
                    }

                    if (!containsLessonTitle)
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (command[0] == "Remove")
                {
                    string lessonTitle = command[1];

                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == lessonTitle)
                        {
                            schedule.RemoveAt(i);

                            if (schedule[i] == lessonTitle + "-Exercise")
                            {
                                schedule.RemoveAt(i);
                            }
                        }
                    }
                }
                else if (command[0] == "Swap")
                {
                    bool lessonTitle1Exist = false;
                    bool lessonTitle2Exist = false;
                    bool containsExercise1 = false;
                    bool containsExercise2 = false;

                    string lessonTitle1 = command[1];
                    string lessonTitle2 = command[2];
                    int indexLessonTitle1 = 0;
                    int indexLessonTitle2 = 0;

                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == lessonTitle1)
                        {
                            indexLessonTitle1 = i;
                            lessonTitle1Exist = true;

                            if (i == schedule.Count)
                            {
                                break;
                            }

                            if (schedule[i + 1] == lessonTitle1 + "-Exercise")
                            {
                                containsExercise1 = true;
                            }
                        }
                        if (schedule[i] == lessonTitle2)
                        {
                            indexLessonTitle2 = i;
                            lessonTitle2Exist = true;

                            if (i == schedule.Count-1)
                            {
                                break;
                            }

                            if (schedule[i + 1] == lessonTitle2 + "-Exercise")
                            {
                                containsExercise2 = true;
                            }
                        }
                    }

                    if (lessonTitle1Exist && lessonTitle2Exist)
                    {
                        if (containsExercise1 && containsExercise2)
                        {
                            schedule.RemoveAt(indexLessonTitle1);
                            schedule.RemoveAt(indexLessonTitle1);
                            schedule.Insert(indexLessonTitle1, lessonTitle2);
                            schedule.Insert(indexLessonTitle1+1, lessonTitle2+"-Exercise");
                            schedule.RemoveAt(indexLessonTitle2);
                            schedule.RemoveAt(indexLessonTitle2);
                            schedule.Insert(indexLessonTitle2, lessonTitle1);
                            schedule.Insert(indexLessonTitle2+1, lessonTitle1+"-Exercise");
                            continue;
                        }
                        if (containsExercise1)
                        {
                            schedule.RemoveAt(indexLessonTitle1);
                            schedule.RemoveAt(indexLessonTitle1);
                            schedule.Insert(indexLessonTitle1, lessonTitle2);
                            schedule.RemoveAt(indexLessonTitle2-1);
                            schedule.Insert(indexLessonTitle2-1, lessonTitle1);
                            schedule.Insert(indexLessonTitle2, lessonTitle1 + "-Exercise");
                            continue;
                        }
                        if (containsExercise2)
                        {
                            schedule.RemoveAt(indexLessonTitle1);
                            schedule.Insert(indexLessonTitle1, lessonTitle2);
                            schedule.Insert(indexLessonTitle1+1, lessonTitle2+"-Exercise");
                            schedule.RemoveAt(indexLessonTitle2+1);
                            schedule.RemoveAt(indexLessonTitle2+1);
                            schedule.Insert(indexLessonTitle2+1, lessonTitle1);
                            continue;
                        }
                        schedule.RemoveAt(indexLessonTitle1);
                        schedule.Insert(indexLessonTitle1, lessonTitle2);
                        schedule.RemoveAt(indexLessonTitle2);
                        schedule.Insert(indexLessonTitle2, lessonTitle1);
                    }
                }
                else if (command[0] == "Exercise")
                {
                    string lessonTitle = command[1];

                    for (int i = 0; i < schedule.Count; i++)
                    {
                        if (schedule[i] == lessonTitle)
                        {
                            if (schedule[i+1]==lessonTitle+"-Exercise")
                            {
                                break;
                            }
                            else
                            {
                                schedule.Insert(i + 1, lessonTitle + "-Exercise");
                                break;
                            }
                        }
                    }
                    schedule.Add(lessonTitle);
                    schedule.Add(lessonTitle + "-Exercise");
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{schedule[i]}");
            }
        }
    }
}
