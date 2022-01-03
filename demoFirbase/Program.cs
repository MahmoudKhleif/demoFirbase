// See https://aka.ms/new-console-template for more information



using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;



/// <summary>
/// an application that we can use Crud in FireBase 
/// </summary>


// conection with fireBase
IFirebaseConfig con = new FirebaseConfig
{
    AuthSecret = "Add here ur authsecret",
    BasePath = "add here ur BasePath"

};
IFirebaseClient client = new FirebaseClient(con);

/// <summary>

//set a data in database
/// </summary>
var db = new Data
{
    ID = 5,
    name = "Mahmoud",
    LastName = "ahmad",
    Address = "Göteborg"
};

//var rs = await client.SetAsync("DataInfo", db);
//Data Result = rs.ResultAs<Data>();


///<summary>
//// push data to database
///</summary>


//var rs = await client.PushAsync("dataInfo", db);
//Data Result = rs.ResultAs<Data>();

///<summary>
////update child in database
///</summary>
//var rs = await client.UpdateAsync("dataInfo/-MsWOUVLjqCDSrAa5c3z", db);
//Data Result = rs.ResultAs<Data>();

/// <summary>
/// //delete child by id
/// </summary>



//var rs = await client.DeleteAsync("dataInfo/-MsWOUVLjqCDSrAa5c3z");
//Data Result = rs.ResultAs<Data>();


/// <summary>
/// Red data from databse
/// </summary>
var rs = await client.GetAsync("dataInfo/-MsWVp7yOPHhnWRfQ9rA");
Data Result = rs.ResultAs<Data>();

Console.WriteLine("succeusfull");
Console.WriteLine($"Id : {Result.ID} name : {Result.name} LastName : {Result.LastName} Address : {Result.Address}");
