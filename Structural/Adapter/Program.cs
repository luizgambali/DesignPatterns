/*
    Adapter Design Pattern C#

    Adapter Design Pattern is a structural design pattern among the Gang Of Four(GOF) Article on GOF Patterns & their types Design Patterns.


    Reference: https://dotnettutorials.net/lesson/adapter-design-pattern/#google_vignette
*/

string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };
            
            
Console.WriteLine("HR system passes employee string array to Adapter\n");
ITarget target = new EmployeeAdapter();
target.ProcessCompanySalary(employeesArray);

