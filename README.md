# AgentApi
- Hi, This is a RestApi using Asp.net Core web API 

## Getting Started

- ### Step 1: Execut this SQL query 

    - Execut this SQL query in SQL server:
    ```
        /* select all this 3 line end click execute */

        create database gestionAgentdb
        go
        use gestionAgentdb


        /***************************************/
        /*	
          after your executing of the code in the top 
          select all this lines end click execute
        */
        create table Agent(
            agentId INT identity PRIMARY KEY NOT NULL,
            agentName VARCHAR(100),
            agentEmail VARCHAR(100),
            agentAddress VARCHAR(255),
            agentMobile VARCHAR(25),
            agentTele VARCHAR(25)
        )

        /***************************************/
        /*	
          after your executing of the code in the top 
          select all this lines end click execute
        */

        --To Add data to Agent Table--
        insert into Agent values('user1','user1@gmail.com','user1address','012542222','1241611212')
        insert into Agent values('user2','user2@gmail.com','user2address','012542222','1241611212')

        --To Update data in Agent Table--
        update Agent set agentName='user3' where agentId=2

        --To Delete data from Agent Table--
        delete from Agent where agentId=2

        --To Display data of Agent Table--
        select * from Agent

    ```
- ### Step 2: Change the Connection String in the Api Project

    - Go to [appsettings.json](https://github.com/Mbouziani/AgentApi/blob/master/appsettings.json) file 
    - Change the connection String in the json file on the tag "AgentAppConnection"
      ```
        {
          "ConnectionStrings": {
            "AgentAppConnection": "Server=DESKTOP-HG4VL0E\\SQLEXPRESS;Database=gestionAgentdb;Trusted_Connection=True;"
          },
          "Logging": {
            "LogLevel": {
              "Default": "Information",
              "Microsoft.AspNetCore": "Warning"
            }
          },
          "AllowedHosts": "*"
        }
      ```
- ### Step 3: That's it you are done, you can Run your Project and use it with success.
