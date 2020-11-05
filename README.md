# ParticleArray-MVC
My original resume website, with MVC and a responsive design... quite novel deisgns from a beginning developer!
This repository is no longer used but I'm keeping it around for posterity's sake.



## Setup notes!
Out of the box, the website will need SSL setup on the local machine and will attempt to use https out of port 1052. You can undo all of this from the project properties and and by removing RequireHttpsAttribute from **FilterConfig.cs**.

Also, **Web.config** has been altered to remove the connection strings and email account settings, for security reasons :D.  So, in order to bring everything up to speed you'll need to...

### Recreate the Database
Use the included **DBModel.edmx** in the **Models** folder.  The structure is there, just right-click and _Generate Database from Model_.  While populating with your own values, take note of the following:
  1. For the slideshow on the home page: take a look at **slideshow.css**.  The transition speed and number of slides is determined by the "@keyframes fade" properties.  It is currently set up to evenly transition over 6 slides.  If you want to have more or less, you will need to do a little math and set the percentages right.
  2. For the **ProjectLink** attribute of the **Projects** table: this value is the end of a share link for a YouTube video.  For example, if you want ProjectLink to point to "https://youtu.be/TCB8e8yLI4Y", then populate the attribute with the value "TCB8e8yLI4Y".
    
### Enter the email stuff
Fill in your own **SMTP settings** and the **MailTo setting string**.  SMTP specifies the sending mailbox.  MailTo specifies the receiving email address.



## And that's it!
