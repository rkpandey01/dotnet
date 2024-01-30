using _03_Facade;

Console.WriteLine("03_Facade:");

// Create an instance of the HomeTheaterFacade
HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade();

// Watch a movie using the Facade
homeTheaterFacade.WatchMovie("The Matrix");

// Stop the movie using the Facade
homeTheaterFacade.StopMovie();

Console.ReadKey();

/*
 * Definition: --------------------------->
The Facade Pattern is a structural design pattern that provides a simplified interface 
to a set of interfaces in a subsystem. 
It defines a higher-level interface that makes the subsystem easier to use. 
In simpler terms, the Facade Pattern acts as a wrapper around a complex subsystem, 
making it easier to interact with.

The Facade Pattern helps to encapsulate the complexity of interacting with multiple subsystem components 
and provides a high-level interface for the client to perform common tasks more easily.


 * Implementation: -----------------------> 
 ---> Step 1: Define the subsystem components -- (AudioPlayer, VideoPlayer, and Display).
 ---> Step 2: Create the Facade class -- (MultimediaFacade) that wraps the subsystem components.
 ---> Step 3: Use the Facade in the client code -- creates an instance of the Facade and uses it to interact 
with the subsystem in a simplified manner.


 * Real-World Scenario: ------------------> 
Interacting with subsystem components (like databases, loggers, and APIs) and provide a simplified interface 
for the client code.
public class DatabaseFacade
{
    private SqlConnection _connection;

    public void Connect(string connectionString)
    {
        _connection = new SqlConnection(connectionString);
        _connection.Open();
    }

    public SqlDataReader ExecuteQuery(string query)
    {
        SqlCommand command = new SqlCommand(query, _connection);
        return command.ExecuteReader();
    }

    public void Disconnect()
    {
        _connection.Close();
    }
}

*/