# The Application
A tournament that sets up a schedule for teams to play each other in a single elimination style matchups.

# Technology Utilized
C#, Multi-form WinForms, In Depth Class Library, SQL Database, Text FIle Storage, Dapper, Linq, Interfaces, E-mailing form C#, Custom Events

## 00 Planning

### Scenario 
Tournament tracker where people play set of games to determine top player. 
Idea is to create tournament bracket system which will tell player who to play.
At the end winner should be identified.

###  Requirments
1. Track games played and their outcome
2. Multiple competitors play in tournament
3. Create tournament plan (who plays who)
4. Schedule games
5. Single lose eliminates a player
6. The last player standing is the winner

##### Questions about project ???
- how many player, order of player random, schedule of game
- can games be played simultaneously, does system need to store scores
- type of frontend ( form, webpage, app .. ), where to store data
- type of reporting, levels of access

##### Requirment extended
- variable number of players, ordering is random, games aren't scheduled, each round is completed before another begins
- store score for each player, desktop app (later webapp), data is tored in SQL server (or txt file)
- reporting specifing the outcome (form, email etc), anyone using the app can fill the game score
- system shouuld notify via email

### Big Picture
- Structure : Windows Form app and Class Library
- Data : SQL and/or Text File
- Users : One at a time on one application
- Key Concepts : Email, SQL, Custom Events, Error Handling, Interfaces, Radnom Ordering, Texting, 


## 01 DataDesign

### Mapping the Data

1. Team
* TeamMembers (List<Person>)
* TeamName (string)

2. Person
* FirstName (string)
* LastName (string)
* EmailAddress (string)
* CellPhoneNumber (string)
 
3. Tournament
* TournamentName (string)
* EntryFee (decimal)
* EnteredTeams (List<Team>)
* Prizes (Lsit<Prize>)
* Rounds (List<List<Matchup>>)

4. Prize
* PrizeNumber (int)
* PlaceName (string)
* PrizeAmount (decimal)
* PrizePercentage (double)

5. Matchup
* Entries (List<MatchupEntry>)
* Winner (Team)
* MatchupRound (int)

6. MatchupEntry
* TeamCompeting (Team)
* Score (double)
* ParentMatchup (Matchup)


## 02 UserInterfaceDesign

```text
### Tournament Viwer Form
----------------------------------------------------------
Tournament: <name>

Round [             ^]
     []Unplayed Only

[matchuplistbox     ]        Sample Team 1
                             Score [         ]

                             VS               [ SCORE ]

                             Sample Team 2
                             Score [         ]
[                   ]
----------------------------------------------------------


### Create Tournament FORM
__________________________________________________________
Create Tournament
  
Tournament Name              Teas / Players
[                   ]        [trournament     ] [Delete
                              PlayerListBox     Selected]
Entry Fee [         ]
                             [                ]
Select Team {create new}
[                    ^]
      [Add Team]             Prizes
                             [prizesListBox   ] [Delete
                                                Selected]
     [Create Prize]
                             [                ]

               [ Create Tournamnet ]
__________________________________________________________


### Create Team FORM
__________________________________________________________
Create Team

Team Name
[                  ]        [tournamentPlayersListBox    ]

Select Team Member
[                 ^]
    [Add Member]

Add New Member
First Name [          ]
Last Name  [          ]
Email      [          ]
Cellphone  [          ]    [                             ]
   [Create Member]

                 [Create Team]
__________________________________________________________
 

### Creat Prize FORM
__________________________________________________________
Create Prize

Place Number       [              ]
Place Naem         [              ]
Place Amount       [              ]

                 - or -

Prize Percantage   [              ]

           [Create Prize]
__________________________________________________________


### Tournament Dashboard FORM
// always open, needed for multiple tournaments
__________________________________________________________
Tournament Dashboard

Load Existing Tournament
[                      ^]

      [Load Tournament]

[Create Tournament]
__________________________________________________________
 ```
 
## 03 Logic Planning
 
1. Create tournament
 - "create new" : create a new team, opens new team form, takes the valuse and puts in Teams / Players box
 - 'Add Team" : adds selected team
 - "Create Prize" : works like "create new", takes the valuse and puts in Prize box
 - "Delete Selected" : delets selected team / prize from box
 - "Create Tournament" : creates tournament

2. Create Team
 - "Add Member" : add exsting player from list and add it too box
 - "Create Member" : takes fileds information and creates member
 - "Create Team" : creates team
 - NEED TO ADD DELETE PLAYER BUTTON

3. Create Prize
 - "Create Prize" : creates prize based on information fields
 
4. Tournament Dashboard
 - "Lead Existing Tournament : loads tournament
 - "Create Tournament" : creates tournament
 
5. Torunament Viewer
 - Tournament "name" : gets updateted
 - "Round" : gets calculated based on tournamnet, "unplayed only" filter to show uplayed rounds
 - "Score" : update match up scores based on displayed team 1 / 2 scores
 
 
 

 

