//Add popup to all a.image items on the page
window.onload = function()
{
    var aVideos = document.querySelectorAll("a.video");
    
    for (var i = 0; i < aVideos.length; i++)
    {
        var aVideo = aVideos[i];
        
        (function (aVideo) {
            aVideo.onclick = function () {
                popup(aVideo.id);
                return false;
            }
        })(aVideo);
        
        console.log("Link created to youTube video " + aVideo.id);
    }
}

//Open popup
function popup(itemId)
{
    if (!document.getElementById("popup"))
    {
        var p = document.createElement("div");
        p.id = "popup";
        p.onclick = function() { closePopup(); };

        var pc = document.createElement("div");
        pc.id = "popupContainer";
        pc.innerHTML = 
            "<input class=\"closeBtn\" type=\"button\" value=\"&Cross;\" onclick=\"closePopup()\"/>" +
            "<iframe src=\"https://www.youtube.com/embed/" + itemId + "?vq=hd1080&autoplay=1&iv_load_policy=3&rel=0&showinfo=0&theme=light&color=white\" frameborder=\"0\" allowfullscreen></iframe>";

        document.body.appendChild(p);
        document.body.appendChild(pc);
        
        console.log("Link opened to youTube video " + itemId);
    }
}

//Close popup
function closePopup()
{   
    var b = document.getElementsByTagName("body");
    b[0].removeChild(document.getElementById("popupContainer"));
    b[0].removeChild(document.getElementById("popup"));
    
    console.log("Link closed");
}