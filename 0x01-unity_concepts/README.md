# 0x01. Unity - Unity Concepts
- [Project Page](https://intranet.hbtn.io/projects/399)

## Learning Objectives
- What is a GameObject
- What is a Component
- What is a Prefab
- What is a Tag
- What is a Layer
- How to create and change the properties of a GameObject
- How to create a Prefab
- How to add Tags and Layers
- Why is it important to name GameObjects and assets clearly and organize your project hierarchy
- What are gameplay and game mechanics and how do they relate to developing any kind of interactive experience

## Task Descriptions
- 0x01-unity_concepts/Assets/Scenes/0-floor.unity : Create a new 3D Unity project called 0x01-unity_concepts. Save your new scene as 0-floor. Create a new Cube GameObject named Floor
- 0x01-unity_concepts/Assets/Scenes/1-ball.unity : Duplicate 0-floor by selecting the scene in the Project window and either Edit > Duplicate from the Toolbar or CTRL / CMD + D. Rename the scene 1-ball and open it. Create a new Sphere GameObject named Ball with the following Transform properties:
- 0x01-unity_concepts/Assets/Scenes/2-colors.unity, 0x01-unity_concepts/Assets/Materials/floor.mat, 0x01-unity_concepts/Assets/Materials/ball.mat : Duplicate 1-ball, rename it 2-colors, and open it. Create a Materials folder in the Project window, then create a new material named floor. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject. Create a second new material named ball. Change the material color and assign the new material to the Ball GameObject.
- 0x01-unity_concepts/Assets/Scenes/3-gravity.unity, 0x01-unity_concepts/Assets/Physic Materials/bounce : Duplicate 2-colors, rename it 3-gravity, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell? Create a new folder in the Project window named Physic Materials and create a new Physic Material called bounce. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the bounce material to the Ball’s Sphere Collider. Press Play.
- 0x01-unity_concepts/Assets/Scenes/4-prefab.unity, 0x01-unity_concepts/Assets/Prefabs/Ball : Duplicate 3-gravity, rename it 4-prefab, and open it. Create a new folder named Prefabs. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene.
- 0x01-unity_concepts/Assets/Scenes/5-more_colors.unity, 0x01-unity_concepts/Assets/Materials/ball-* : Duplicate 4-prefab, rename it 5-more_colors, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. Rename each Ball GameObject in your scene with their color name.
- 0x01-unity_concepts/Assets/Scenes/6-tags.unity, 0x01-unity_concepts/Assets/Prefabs/Ball.prefab : Duplicate 5-more_colors, rename it 6-tags, and open it. Add a tag to all Ball objects called Obstacles.
- 0x01-unity_concepts/Assets/Scenes/100-textures.unity, 0x01-unity_concepts/Assets/Materials/ball-texture, 0x01-unity_concepts/Assets/Textures/<texture_name> : Duplicate 6-tags, rename it 100-textures, and open it. Create a new instance of Ball named Textured Ball and add a texture to it. Your texture asset should be in a folder named Textures and your new material should be called ball-texture.
