 # Bug Tracker Requirements and Specifications 

 ### The Main Idea

This web based solution will provide an easy to use ticketing system for development. Project managers will be able to create projects, assign team member roles, and create feature or bug tickets for developers to be assigned to. The goal is to provide a streamlined communication tool between project managers/customers and the developers of a product and to create a more efficient development pipeline.

### Tools we will be using

1. React JS front end, .NET core backend (C#)
2. CSS library for consistent visuals (Probably Bootstrap)
3. DB solution with cloud hosting (sql or nosql unknown as of 6/25/2023)
4. Hosting Platform for the product (AWS)

# Features


## User Options
### User Login and Authentication
- [ ] User Table that stores account information such as role, ID, email, etc.
- [ ] Auth0 authentication

### User Role Management
- [ ] Admin has access to an edit user role page
- [ ] List of all users of the site
- [ ] Admin can add users to an organization
- [ ] Roles can be changed, added, and removed (Admin, PM, Dev, Customer)
- [ ] Can be filtered by user's name, role, company

## Main Dashboard
### Dashboard Graphs (Maybe)
variety of graphs that display bugs for a user

### Project List/Landing page
- [ ] Users will have a page that lists all of their current projects
- [ ] Lists project name, company, PM, user's role, total tickets for the project, user's total assigned tickets
- [ ] Project managers will have a button to create new projects here
- [ ] Can be filtered by priority, date assigned, date completed, project name

### Ticket List
- [ ] Page that a dev can view all tickets assigned to them, no matter the project
- [ ] User can choose to view the ticket in detail or be redirected to the project
- [ ] Can be filtered by priority, date assigned, date completed, company, ticket name

## Projects

### Create Project page
- [ ] Only accessible to PM role
- [ ] Can assign title, description, members, project priority level

### Edit Project page
- [ ] PM's can edit information such as project members, project name, description, project priority level
- [ ] Members can be added and removed
- [ ] Project can be marked as in progress or complete

### View Project
- [ ] Any member of the project may view
- [ ] List of tickets
- [ ] Each ticket has a name, short description, member(s) assigned, priority level, comments
- [ ] Any member may leave a comment on any ticket
- [ ] PM's and Customers have access to a create ticket button

## Tickets

### Create Tickets
- [ ] PMs/Customers can create tickets with varying priority levels (low, medium, high, etc.)
- [ ] The ticket has a name, description, and assigned devs. Tickets have comments which can be left by the devs, customers, or the manager

### Edit Tickets
- [ ] PMs/Customers can edit all information about the tickets they have created

### View Tickets
- [ ] Access tickets from the project page. Shows details on it's own page
- [ ] Paginated comment section
- [ ] PM's may delete any comment
- [ ] Devs and Customers may only delete their own comments
- [ ] Can be filtered by priority, date assigned, date completed, company, ticket name, assigned dev name
- [ ] Devs can request a ticket review once the task is completed which will send to the PM
- [ ] PM's have the option to resolve a ticket

## Misc

### Notification inbox
- [ ] Small inbox in corner of screen that can be opened up
- [ ] Users notified of projects they are assigned to/removed from (link to project if newly assigned)
- [ ] Dev, Customer notified of any changes to a ticket (name change, new comments, ticket resolution status, priority change, etc.). Simple message with link to ticket
- [ ] Dev, Customer notified of project completion

### Account page
- [ ] Any user can view another user's account page
- [ ] Account owner has option to edit their account which redirects them to an edit page
- [ ] User can edit username, email, password, bio

### Edit/Resolve tickets
Once the dev completes the task, they submit a resolve request to the manager. If the manager accepts the request, the ticket is marked as resolved

# More to be decided
