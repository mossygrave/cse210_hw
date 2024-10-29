public class GoalManager
{
    //Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0; 
    Animations animations = new Animations(); //animation library i am working on

    //Constructors

    //Methods
    public void Start()
    {
        //starts the program

        bool quit = false;
        Console.Clear();
        Console.WriteLine("~~Eternal Quest~~");
        Console.WriteLine(); 

        while (quit == false)
        {


            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option from the menu: ");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "1")
            {
                Console.Clear();
                CreateGoals();
            }
            else if (input == "2")
            {
                ListGoalDetails();
                DisplayPlayerInfo();
            }
            else if (input == "3")
            {
                SaveGoals(); //I could probably use try ... here
                Console.Write("Saving");
                animations.ShowSpinner(5);
                Console.Clear();
                Console.WriteLine("Your file was saved!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (input == "4")
            {
                LoadGoals(); //I could probably use try ... here
                Console.Write("Loading");
                animations.ShowSpinner(5);
                Console.Clear();
                Console.WriteLine("Your file was successfully loaded!");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            else if (input == "6")
            {
                Console.Clear();
                Console.Write("Would you like to save first? (y/n): ");
                input = Console.ReadLine();

                if (input == "y")
                {
                    SaveGoals();
                }

                Console.Write("Goodbye");
                animations.ShowSpinner(5);
                quit = true;
            }
        }
        //has menu options
    }

    public void DisplayPlayerInfo()
    {
        //shows player score 
        //shows list of goals and their description

        Console.WriteLine();
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        //print the names of all the goals
    }

    public void ListGoalDetails()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            string details = goal.GetDetailsString();
            Console.WriteLine($"{num}. {details}");
            num ++;
        }
    }

    public void CreateGoals()
    {
        //gets input from the user 
        Console.WriteLine();
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            //create simple goal
            Console.Write("Please enter the name of your new goal: ");
            string name = Console.ReadLine();
            
            Console.Write("Please input the description: ");
            string description = Console.ReadLine();
            
            Console.Write("Please input the number of points: ");
            string strPoints = Console.ReadLine();
            int points = int.Parse(strPoints);

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (input == "2")
        {
            //create eternal goal
            Console.Write("Please enter the name of your new goal: ");
            string name = Console.ReadLine();
            
            Console.Write("Please input the description: ");
            string description = Console.ReadLine();
            
            Console.Write("Please input the number of points: ");
            string strPoints = Console.ReadLine();
            int points = int.Parse(strPoints); 

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (input == "3")
        {
            //create checklist goal
            Console.Write("Please enter the name of your new goal: ");
            string name = Console.ReadLine();
            
            Console.Write("Please input the description: ");
            string description = Console.ReadLine();
            
            Console.Write("Please input the number of points: ");
            string strPoints = Console.ReadLine();
            int points = int.Parse(strPoints);
            
            Console.Write("Please input the number of times for the goal to be completed: ");
            string strTarget = Console.ReadLine();
            int target = int.Parse(strTarget);
            
            Console.Write("Please input the amount of bonus points: ");
            string strBonus = Console.ReadLine();
            int bonus = int.Parse(strBonus);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        Console.Clear();
        //adds the new goal to the list
    }

    public void RecordEvent()
    {
        //gets user input and registers if the user completed a goal
        
        //lists all the goals 
        ListGoalDetails();
        
        //user selects a number (index)
        Console.WriteLine();
        Console.Write("Pick a goal to record an event for: ");
        string input = Console.ReadLine();
        
        //finds goal in list
        int choice = int.Parse(input);
        choice -= 1;
        
        //runs the record event method for that goal
        Goal goal = _goals[choice];
        int points = goal.RecordEvent();

        _score += points;
        Console.Write("Saving");
        animations.ShowSpinner(3);
        Console.WriteLine($"Score: {_score}");
        
    }

    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("Please input the file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Please input the file name: ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            if (parts[0] == "Simple Goal")
            {
                string name = parts[1];
                string description = parts[2];
                string strpoints = parts[3];
                string strcomplete = parts[4];

                int points = int.Parse(strpoints);
                bool complete = bool.Parse(strcomplete);

                if (complete == true)
                {
                    _score += points; 
                } //calculates the score based on the saved goal

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, complete);
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "Eternal Goal")
            {
                string name = parts[1];
                string description = parts[2];
                string strpoints = parts[3];
                string strtimes = parts[4];
                
                int points = int.Parse(strpoints);  
                int times = int.Parse(strtimes);   

                int value = points * times;
                _score += value; //calculates the score based on the saved goal

                EternalGoal eternalGoal = new EternalGoal(name, description, points, times);
                _goals.Add(eternalGoal);      
            }
            else if (parts[0] == "Checklist Goal")
            {
                string name = parts[1];
                string description = parts[2];
                string strpoints = parts[3];
                string strcompleted = parts[4];
                string strtarget = parts[5];
                string strbonus = parts[6];
                
                int points = int.Parse(strpoints);
                int completed = int.Parse(strcompleted);
                int target = int.Parse(strtarget);
                int bonus = int.Parse(strbonus);

                int value = completed * points;

                if (completed == target)
                {
                    value += bonus;
                }

                _score += value; //calculates the score based on the saved goal

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, completed, target, bonus);
                _goals.Add(checklistGoal);
            }
        }
    }

}

//maybe i should have made a score manager class.....