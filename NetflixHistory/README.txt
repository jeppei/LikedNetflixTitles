Author: Jesper Lundin

This application was made 2022-01-01. At that time the Netflix ratings could be fetched 
by the following steps:

1) Log into Netflix
2) Choose you account
3) Go to Account
4) Scroll down to Profile & parental controls"
5) Expand the profile whoose ratings you want to use
6) Click "View" next to "Ratings"
7) In chrome open dev tools and go to the network tab
8) At the bottom of the rating list, click "Show More"
9) In dev tools, look for the call to ratinghistory
10) Rightclick on ratinghistory and click "Open in new tab"

For me the url was: https://www.netflix.com/api/shakti/v5185b692/ratinghistory?pg=0

11) Use the query parameter "pg=1"
 - Start with pg=0 and save the site as a json file
 - Increase pg on step at the time and save each response to json files
 - At some point ratingItems will be empty in the response and no more titles will appear
12) put all the json files in Watch history.


The JSON files whould have the following structure or the application might not work.

{
    "codeName": "S-Icarus-6.Demitasse-5",
    "ratingItems": [
        {
            "ratingType": "thumb",
            "title": "Suits",
            "movieID": 70195800,
            "yourRating": 2,
            "date": "2020-10-29",
            "timestamp": 1603998521419,
            "comparableDate": 1603998521
        },
        ...
    ]
}


This endpoint might be changed by Netflix in the future.

To improve this application, 
- authentication to Netflix can be implemented 
- let the application use the same cookies as a webbrowser
- Use a library and implement a webbrowser in this application
Then perform the calls to ratinghistory via code instead of reading the json files.