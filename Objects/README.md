# _Band Tracker_

#### _Band Tracker Website, Epicodus C# Week 4 Code Review, 3.3.17_

#### By _**Caitlin Hines**_

## Description

_This application will allow users to # _Hair Salon_

#### _Hair Salon Website, Epicodus C# Week 3 Code Review, 2.24.17_

#### By _**Caitlin Hines**_

## Description

_This application will allow users of the site to: see a list of venues, select a venue and see a list of the bands playing there, add a new venue to the site, add new bands to a specific venue, see a list of bands, select a band and see a list of the venues hosting that band, add a new band to the site, also update and delete venues_

## Specifications

#### The GetAll method will return an empty list if the list of bands is empty in the beginning
* Input: nothing/null
* Output : empty string


#### The Equals method will return true if there two bands that are the same.
* Input: Radiohead, Radiohead
* Output : true


#### The GetAll method will return a band if the band was saved in the database.
* Input: "Radiohead"
* Output : "Radiohead"


#### The Save method will assign a new id to a new instance of the band class.
* Input: Radiohead, 0
* Output : Radiohead, non zero

#### The GetAll method will return a list of of all bands.
* Input: Radiohead, Fleetwood Mac, U2
* Output : Radiohead, Fleetwood Mac, U2

#### The Find method will return the band in the database.
* Input: Radiohead
* Output : Radiohead

#### The GetAll method will return an empty list if the list of venues is empty in the beginning.
* Input: Nothing/null
* Output : empty string

#### The Equals method will return true if there are two venues that are the same.
* Input: Gorge, Gorge
* Output : true

#### The Save and Getall method will return true if the venue was saved in the database.
* Input: Gorge
* Output : true

#### The GetAll method will return true if the id for the first venue has an id of 1.
* Input: Gorge
* Output : 1

#### The GetAll method will return a list of venues.
* Input: Gorge, Key Arena, Paramount
* Output : Gorge, Key Arena, Paramount

#### When a user updates a venue, the Update method will return the updated info.
* Input: Gorge Amphitheater replacing Gorge
* Output : Gorge Amphitheater

#### When a user deletes a venue, the Delete method will return an updated list without the deleted venue.
* Input: DELETE Gorge Amphitheater
* Output : Key Arena, Paramount

## Support and contact details

_Contact: Caitlin Hines- caitlinhines@me.com_

## Technologies Used

## Setup/Installation Requirements

* SQLCMD:
* CREATE DATABASE band_tracker;
* GO
* USE band_tracker;
* GO
* CREATE TABLE bands (id INT IDENTITY(1,1), name VARCHAR(255));
* CREATE TABLE venues (id INT IDENTITY(1,1), name VARCHAR(255));
* GO
* _Clone github repository:https://github.com/Band-Tracker
* _run dnu restore in terminal.
* _reset server with "gnx kestrel"_
* _Open webpage on localhost:5004_

_HTML, CSS, Nancy, Razor, C#, SQL_

### License

*MIT*

Copyright (c) 2017 **_Caitlin Hines_**._
