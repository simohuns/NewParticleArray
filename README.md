# NewParticleArray
My original resume website, but reworked to use MVC and a responsive design.
Feel free to take a look around!  If you have questions/comments, send an email to contact@particlearray.net


# Setup notes!
Web.config has been altered to remove the connection strings and email account settings.  For security reasons :D.  The website will run without any additional setup, but much of it will be empty.  So, in order to bring everything up to speed you'll need to...

  1. Recreate your own database from the included DBModel.edmx in the Models folder.  The structure is there, just right-click and "Generate Database from Model".  While populating with your own values, take note of the following:
    -For the slideshow on the home page: take a look at slideshow.css.  The transition speed and number of slides is determined by the "@keyframes fade" properties.  It is currently set up to evenly transition over 6 slides.  If you want to have more or less, you will need to do a little math and set the percentages right.
    -For the ProjectLink attribute of the Projects table: this value is the end of a share link for a YouTube video.  For example, if you want ProjectLink to point to "https://youtu.be/TCB8e8yLI4Y", then populate the attribute with the value "TCB8e8yLI4Y".
    
  2. Fill in your own SMTP settings and MailTo setting string.  SMTP specifies the sending mailbox.  MailTo specifies the receiving email address.

And that's it!
