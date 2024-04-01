// I excedeed the requirements because my program displays the level that the user has acording to their
// score. There are 6 levels that the user can reach. The user levels up every 200 points until
// reaching 1000 points. The level can be saved and loaded from a file.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}