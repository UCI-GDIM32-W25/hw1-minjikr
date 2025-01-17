[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Objects
- UI
  - Seeds Planted UI
  - Seeds remaining UI
- Player : Bunny
- Plant

Attributes and Actions
- The player starts in the middle of the game scene.
- Using WASD keys, the player moves.
- Using the space key, the plant is planted at the player’s current position.
- The planting directly updates the UI by increasing ‘Seeds Planted’ count and decreasing ‘Seeds remaining’ count.

## Devlog

As instructed, before starting the implementation, I followed the instructions to create a plant prefab and set it up in the game. This connected my code and unity environment. The player was already set in the middle, which was one of the aspect I planned. Then, I worked on the player’s movement using the WASD keys. Initially, I used Input.GetKeyDown, but the movement felt choppy and wasn’t smooth. To fix this, I switched to Input.GetKey, which allowed continuous movement while the key was held down. I also normalized the movement and scaled it by speed and deltaTime to make sure it felt consistent and smooth regardless of the frame rate.

Once movement was working, I implemented the planting mechanic using space key. It runs `PlantSeed()`, which makes the plant to instantiate at the player’s position. At the same time, the UI needed to be updated by increasing ‘Seeds Planted’ count and decreasing ‘Seeds remaining’ count. The `UpdateSeeds()` in the `PlantCountUI` script dynamically updates the UI to reflect these changes. In Unity, to make the game playable, I added the components and linked the UI text elements to 'Planted Text,' and 'Remaining text' on script. Additionally, I added two layers to make sure the plant appears above the player when planted.

The breakdown provided clear instructions that effectively guided the development process. However, I initially overlooked certain details, such as adjusting the player's speed and setting of the scene layers. In future development, these aspects should be planned in advance to ensure the game is designed to be more polished and structured.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for effectively connecting the break-down to your code in your Devlog and for formatting your break-down well!
