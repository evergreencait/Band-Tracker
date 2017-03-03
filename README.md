# _Band Tracker_

#### _Band Tracking Website, Epicodus C# Week 4 Code Review, 3.3.17_

#### By _**Caitlin Hines**_

## Description

_This application will allow users to: see all bands that have played at a venue, list bands that have played at a single venue, view a band and see all of their venues, and allow the user to add a venue to that band._

## Specifications

#### The GetAll method will return an empty list if the list of bands is empty in the beginning
* Input: nothing/null
* Output : empty string


#### The Equals method will return true if there two bands that are the same.
* Input: Radiohead, Radiohead
* Output : true

#### The Save method will assign a new id to a new instance of the band class.
* Input: Radiohead, 0
* Output : Radiohead, non zero

#### The Find method will return the band in the database.
* Input: Radiohead
* Output : Radiohead

#### The AddVenue method will return true if a venue is added to a band.
* Input: Gorge, Radiohead
* Output: true


#### The GetAll method will return an empty list if the list of venues is empty in the beginning.
* Input: Nothing/null
* Output : empty string

#### The Equals method will return true if there are two venues that are the same.
* Input: Gorge, Gorge
* Output : true

#### The Save and Getall method will return true if the venue was saved in the database.
* Input: Gorge
* Output : true

#### The AddBand method will return true if a band is added to a venue.
* Input: Radiohead, Gorge
* Output: true

#### The GetBands method will return a list of bands that have played at that venue.
* Input: Gorge
* Output: Radiohead, Fleetwood Mac


#### When a user updates a venue, the Update method will return the updated info.
* Input: Gorge Amphitheater
* Output : Gorge Amphitheater

#### When a user deletes a venue, the Delete method will return an updated list without the deleted venue.
* Input: DELETE Gorge Amphitheater
* Output : Paramount, Key Arena

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

Copyright (c) 2017 **_Caitlin Hines_**
