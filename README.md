# Constellations - 3D drawing minigame 
Thank you for looking at Constellations!
Constellations is a small minigame created for a tech test in two days. Navigate with the stars and create your own constellations in the sky.
Using a first-person camera attached to mouse movements, click and drag across the sky to draw lines in 3D using LineRenderer, and create constellations connecting the star above you. The minigame is aimed at older children roughly age 8-10, but would be suitable for younger or older children. 

## The Brief
This minigame was created for a tech test. The overall brief was to design and implement a Unity minigame that distracts the user during a painful procedure, targetted towards children.

# The Idea
One day was taken to brainstorm, plan and plan some more - I was also travelling and did not have access to my laptop to start programming that day. 

I aimed to create a minigame that relaxed and distracted the user, as well as having simple controls that did not require a lot of movement if this was translated over to a VR app. This would mean that the procedure would not be disturbed by the user moving around greatly, or can be played with a single hand in the case of the other arm being part of the procedure (like having a cast put on).
I also wanted the app to be endless, as medical procedures and the time waiting for the procedure to start can vary greatly. Additionally, I intended on making a slow moving scene so not to make the user feel motion sick. And again, I chose to make a first-person minigame to show how this might be translated into VR.

Quickly, the image of sailing a ship on a calm sea and looking up at the stars came to my mind. The scene is both relaxing and exciting with the idea of exploring the stars and creating patterns in the sky. 
The user would be the captain of a ship, and tasked to look up at the sky and create constellations to navigate the seas. Stars would slowly move above you and you would connect-the-dots to draw constellations.

This minigame hopes to spark some creativity in the user (the child) as well as feed their excitement for exploration. Here they are given a tool to draw and create what they want in a relaxed, beautiful virtual space. 
Simple controls are used and short, easy instructions are given so the user can quickly jump into playing.

# Development
The second day was focused on programming and making those plans a game. The project was solely created in Unity 2020.3.18f1.

The idea was instantly scaled back to the version you can play here. The ship is scaled back to a simple raft created in Unity. A simple plane was added to be the sea. 
First-person controls were added to the main camera, making the camera rotation limited to make sure the user could not get lost behind them.

To draw the constellations, new GameObejcts were created on left mouse button with LineRenderer components. I had seen LineRenderer used for 2D and UI games before, but I had not used them myself, and not in 3D world-space. Despite this project being a tech test, I still took the opportunity to learn something new. 


# How Constellations can be expanded
With more time, Constellations could be expanded slightly or dramatically into a bigger game.

 - The raft which you sail could be a full ship modelled outside of Unity. 
 - The water could look more like water either by adding a shader animation or texture.
 - The stars could not be stationary as they are now. They could be procedurally generated from a starting point and move slowly across the sky; or they could be randomly instantiated in positions across the sky and slowly fade away.
 - The stars could be used as anchor points for the constellations so they must be drawn using the star points.
 - With more time, I would like the constellations to be drawn with straight lines, or for them to be more smooth.
 - The contellations created could be saved into a ledger which could be accessed in the UI.
 - Disable the user from drawing stars not in the sky (such as on the raft).

 - This ship could also be explored as part of a wider game, with this minigame being accessed through a telescope. With other minigames relating to navigation, sailing and the stars.
 - And the game could also be a learning tool to teach children about astronomy and real constellations, or the history of navigation and exploration using the stars.
 - And with more time I would like to make a prettier Main Menu and UI elements.

# How to Open

 - Download this folder for both the application build and the Unity
   project files onto Windows computer.
 - Open the build folder and access the Windows application (.exe file).

# How to Play
Move the camera using mouse movements.
Left click and drag to draw constellations in the sky.
Right click to pause the game and show the pause menu. Here you can clear the screen, resume or return to the main menu.

# Third Party Assets
The skybox used in this project is called ColorSkies by PULSAR BYTES and can be accessed here: https://assetstore.unity.com/packages/2d/textures-materials/sky/colorskies-91541
