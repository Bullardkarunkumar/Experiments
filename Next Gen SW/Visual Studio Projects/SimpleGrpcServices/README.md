This is a mockup of simple 
- equipment driver services 
- test action services 
- a test

Both actions and equipment have a gRPC interface. 

Protobufs (interfaces) are defined for each action and equipment. 

Test calls an action which uses other actions and equipment. 

Test results are stored in a MongoDB database

Everything is in one C# solution. Separate projects for Test, Equipment, Action and DataStore. All these can be debugged from inside Visual Studio.

You need to change the connection string (add a valid username and password) to write to the database.
Database name is **ets_tests**

There are two collections **tests** and **data**.

**Note : This code is just for a quick demo. It is not pretty or clean. Has no error checking , no documentation.  It can be greatly improved.**
