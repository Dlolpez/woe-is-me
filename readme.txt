Project Name: Woe is Me

What the application does?
The application is a isometric third person shooter. It consists in you fighting for your life against endless waves of pirate robots in the middle of the ocean. 

How to use it?
The game ends when you get killed by the monsters. The more monsters you kill, the higher your score.
Controls: 
*Left Virtual Joystick is for movement
*Right Virtual Joystick is for aiming and shooting
*Shake the device OR press SPACE to pause the game

Instructions:
-The red line when shooting indicates the exact direction where your player is shooting.
-The green slider in the upper right side of the screen indicates the health points of the player. You start with 100 and the game ends whenever you reach 0.
-Avoid getting surround by the monsters, the corners of the map are particularly dangerous.

How are the objects and entities modelled?
The most complex objects such as the player, the monsters and the containers are imported from the Unity Asset Store. The simpler objects like the floor plane and the level barriers were modelled in unity itself.

How are graphics and camera motion handled?
Note: The use of an ortographic camera was intentional since we consider is the most suitable type of view for our game. It allows the player to see the surroundings clearly.
The camera motion is implemented with a very simple script that follows the player on the map (CameraFollow.cs) it simply moves according to the player position and applies a smoothing to avoid making the movement so harsh.

The graphics was by far the hardest part in the implementation of the game. Fortunately, we got working a surface shader to make a simple plane look like a realistic ocean (see the Water.shader). It supports textures and even bump mapping. Furthermore, some simple particle systems were used for the effect of fire on the truck.
Finally, the game uses a Cel or Toon shader for most of the objects in the game. This was implemented with the help of the tutorial listed below, though some modifications had to be made for example, for texture support.

No APIs have been used for the development of this game.
The code used was ours however several tutorials were used in the creation of the game and it is worth citing them: 
https://unity3d.com/learn/tutorials/projects/survival-shooter-tutorial
https://www.youtube.com/watch?v=UfX9dzhBhg0
https://en.wikibooks.org/wiki/Cg_Programming/Unity/Toon_Shading