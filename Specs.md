 # Bug Tracker Requirements and Specifications 

 ### The Main Idea

This web based solution will provide an easy to use ticketing system for development. Project managers will be able to create projects, assign team member roles, and create feature or bug tickets for developers to be assigned to. The goal is to provide a streamlined communication tool between project managers/customers and the developers of a product and to create a more efficient development pipeline.

### Tools we will be using

1. .NET framework (c#)
2. CSS library for consistent visuals (Bootstrap)
3. DB solution with cloud hosting (sql or nosql unknown as of 6/25/2023)
4. Hosting Platform for the product (AWS)

## Features

### User Login and Authentication
Users will be prompted to login or sign up at a landing page. Undecided whether we will use auth0 or similar authentication platforms or handle authentication ourselves

### User Role Management
An Admin can add users to an organization and make them either project managers or devs

### Account page
Users will have a page where they may change account information such as bio, username, company, etc.

### Dashboard Graphs (Maybe)
variety of graphs that display bugs for a user

### Project List
Users will have a page that lists all of their current projects. Users will have a button to create new projects here

### Create Project page
Create a project and add members

### Edit Project page
Users can edit information such as project members, project name, description

### Create Tickets
Managers of a project can create tickets with varying priority leveles (low, medium, high, etc.) The ticket has a name, description, and assigned devs. Tickets have comments which can be left by the devs or the manager

### Edit/Resolve tickets
Once the dev completes the task, they submit a resolve request to the manager. If the manager accepts the request, the ticket is marked as resolved

# More to be decided
