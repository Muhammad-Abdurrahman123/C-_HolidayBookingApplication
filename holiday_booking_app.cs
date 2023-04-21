using System; 

 

public class Program 

{ 

public static void Main() 

{ 
 // Select your destination
int DestSelect=0; 

// Select your hotel
int hotelSelect=0; 

// Select your duration of stay
int weekSelect=0;	

// Number of adults on the trip
int adultNumber=0;

// Number of children
int childNumber=0;	

// Price of the flight
int destPrice=0; 
	
// Price of the hotel
int hotelPrice=0; 
	
// The total hotel price for an adult	
int hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);
	
// The calculation for the price of children	
int childPrice=((hotelPrice * weekSelect * childNumber) / 2);
	
// The calculation for the total price	
int totalPrice=(hotelTotalAdult + childPrice + destPrice);
	
// Below are two lines of code that are responsible for creating a while loop, giving the user the option to restart this program.	
bool runAgain=true;

while (runAgain)
{

Console.WriteLine("Holiday System"); 

Console.WriteLine("1: Spain = 200"); 

Console.WriteLine("2: UK = 0"); 

Console.WriteLine("3: France = 120"); 

Console.WriteLine("Make selection 1, 2, or 3"); 

 

DestSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected: " + DestSelect); 

  

////////////////////////////////////////////////////////////////////////// 

if(DestSelect==1) 

{// dest 1 if started 

destPrice=200;  

Console.WriteLine("You selected Spain at £" + destPrice); 

Console.WriteLine("Hotels in Spain"); 

	Console.WriteLine("Hotel 1: Hotel Uno at £100"); 

	Console.WriteLine("Hotel 2: Hotel Dos at £200"); 

	Console.WriteLine("Hotel 3: Hotel Tres at £300"); 

Console.WriteLine("Make selection 1, 2 or 3"); 

 

hotelSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected " + hotelSelect); 

 

if (hotelSelect==1) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Uno"); 

	hotelPrice=100; 

	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}


} 

  

else if (hotelSelect==2) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Dos"); 

	hotelPrice=200;

	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}

	} 

  

else if (hotelSelect==3) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Tres"); 

	hotelPrice=300; 
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}

} 

}// dest 1 if ended 

  

//////////////////////////////////////////////////////////////////////////////////// 

else if (DestSelect==2) 

{// dest 2 if started 

destPrice=0; 

Console.WriteLine("You selected UK at " + destPrice); 

Console.WriteLine("Hotels in UK"); 

	Console.WriteLine("Hotel 1: Hotel One at £100"); 

    Console.WriteLine("Hotel 2: Hotel Two at £200"); 

    Console.WriteLine("Hotel 3: Hotel Three at £300"); 

Console.WriteLine("Make selection 1, 2 or 3"); 

 

hotelSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected " + hotelSelect); 

 

if (hotelSelect==1) 
if (hotelSelect < 1 || hotelSelect > 3)
{
	Console.WriteLine("Invalid input, please try again. Only inputs of 1, 2 or 3 are accepted");
	return;
}

{ 

	Console.WriteLine("Thank you for selecting Hotel One"); 

	hotelPrice=100; 
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}
	} 

  

if (hotelSelect==2) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Two"); 

	hotelPrice=200; 
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}

	}  

else if (hotelSelect==3) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Three"); 

	hotelPrice=300;
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}

	} 

}// dest 2 if ended 

  

//////////////////////////////////////////////////////////////////////////////

if(DestSelect==3) 

{// dest 3 if started 

destPrice=120; 

Console.WriteLine("You selected France at " + destPrice); 

Console.WriteLine("Hotels in France"); 

	Console.WriteLine("Hotel 1: Hotel Un at £100"); 

    Console.WriteLine("Hotel 2: Hotel Deux at £200"); 

    Console.WriteLine("Hotel 3: Hotel Trois at £300"); 

Console.WriteLine("Make selection 1, 2 or 3"); 

 

hotelSelect = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("You selected " + hotelSelect); 
if (hotelSelect < 1 || hotelSelect > 3)
{
	Console.WriteLine("Invalid input, please try again. Only inputs of 1, 2 or 3 are accepted");
	return;
}

if (hotelSelect==1) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Un"); 

	hotelPrice=100; 
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}

} 

  

else if (hotelSelect==2) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Deux"); 

	hotelPrice=200; 
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}

} 

  

else if (hotelSelect==3) 

{ 

	Console.WriteLine("Thank you for selecting Hotel Trois"); 

	hotelPrice=300; 
	
	Console.WriteLine("How many weeks will you stay at the hotel? Select 1, 2 or 3");

	weekSelect = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("You selected " + weekSelect);

	Console.WriteLine("How many adults will stay at the hotel?");

	adultNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(adultNumber + " adults will stay at the hotel");

	Console.WriteLine("How many children will be staying at the hotel?");

	childNumber = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine(childNumber + " children will stay at the hotel");

	childPrice=((hotelPrice * weekSelect * childNumber) / 2);

	hotelTotalAdult=(hotelPrice * weekSelect * adultNumber);

	totalPrice=(hotelTotalAdult + childPrice + destPrice);

	Console.WriteLine("\nThe total cost is £" + totalPrice);
	
	Console.WriteLine("\nDo you wish to confirm your booking? 1 for Yes. 2 for No");
	
	int confirmation = int.Parse(Console.ReadLine());
	
	if (confirmation == 1)
	{
		Console.WriteLine("Booking confirmed. Thank you for using our booking application. Have a nice holiday!");
	}
	else if (confirmation == 2)
	{
		Console.WriteLine("Booking canceled.");
	}
	
	Console.WriteLine("\nDo you want to use the booking application again? 1 for Yes. 2 for No");
		
	int choice = int.Parse(Console.ReadLine());
	
	if (choice == 2)
	{
		runAgain = false;
		Console.WriteLine("Thank you for using our application.");
	}
}

} 

} // dest 3 if ended 

} 

} 	
