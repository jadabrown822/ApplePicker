Apple Picker
===============

1. Read over Bond Ch 16 where they analyze the Apple Picker and Kaboom! games.
2. Do the Apple Picker tutorial from Bond Chapter 29.
3. Enhance the Finished Apple Picker project in the following ways:
   a. Add a start screen with a start button.
   b. Change the game so that there are 4 baskets instead of 3.
4. Add a UI object at the center top of the game that tells the player what round they are in. It should dtart with saying something like "Round 1" and continue through "Round 4". It should say "Game Over" when the game ends. Also, add a restart button.
5. Add a falling object that you don't want to catch in the basket (for example, a branch). Catching a branch should result in "Game Over." Branches should fall much less frequently than apples.

__Submission:__
Submit a one-page PDF file on Moodle that contains a GitHub link to you project


# Set up for the project
* __Project Template:__ 3D Core
* __Project Name:__ Apple Picker
* __Scene Name:__ _Scene_0


## Preparing
### Getting Started: Art Assets
* __AppleTree__

   __1.__ From the Unity menu bar, choose _GameObject > 3D Object > Cyinder_. This will be the trunk of the tree.

   __a.__ Select the Cylinder in the Hierarchy.
  
   __b.__ Click its name (Cylinder) at the top of the Inspector and set the name to _Trunk_

   __c.__ Set the Transform component of Cylinder to match the settnigs in the Transformation component:
   * P:[0, 0, 0]
   * R:[0, 0, 0]
   * S:[1, 1, 1]

   __2.__ Now create a new sphere by choosing _GameObject > 3D Object > Sphere_ from the menu bar. Rename the Sphere to _Leaves_ and set its transform:
   * P:[0, 0.75, 0]
   * R:[0, 0, 0]
   * S:[3, 2, 3]

   __3.__ From the menu bar, choose _GameObject > Create Empty_. This should create an empty GameObject. Make sure that its transform is set to the following:
   * P:[0, 0, 0]
   * R:[0, 0, 0]
   * S:[1, 1, 1]

   __4.__ In the Hierarchy pane, first change the name of the empty GameObject to _AppleTree_. Another way to do this is by clicking the name _GameOBject_ to highlight it, waiting for a second, and either pressing F2 or clicking it a second time.

   __5.__ Individually drag the Trunk and Leaves GameObjects onto AppleTree, and they will be placed under AppleTree in the Hierarchy. If they are hidden under AppleTree, click the new disclosure triangle next to the word _AppleTree_ to see them.

   __6.__ Select _Dimetional Light_ in the Hierarchy and set its position to P:[0, 0, 0]

   * __Pivot/Center:__ The left button switches between _Pivot_ (the point about which the GameObject scales and rotates) and _Center_ (the geometrical center of the GameObject).
   * __Global/Local:__ The right buttong switches between _Global_ (positioned relative to world/global coordinates; in Global mode, the green Y axis of the move tool always points up) and _Local_ (positioned relative to the rotation of this GameObject; in Local mode, the green Y axis of teh move tool points up relative to the rotatino of the selected GameObject).

   __7.__ Set buttons to ___Pivot___ and ___Global___

   __8.__ Set the transform of AppleTree to the following:
   * P:[0, 0, 0]
   * R:[0, 0, 0]
   * S:[2, 2, 2]

   __9.__ Add a Rigidbody component to AppleTree by selecting AppleTree in the Hierarchy and choosing _Component > Physics > Rigidbody_ from the Unity Menu

   __10.__ Select _AppleTree_, and its _Rigidbody_ component Inspector, uncheck _Use Gravity_. If left checked, the tree will fall down off the screen when scene is played.

   __11.__ Save the scene!


* __Sample materials of AppleTree__

   __1.__ From the menu bar, choose _Assets > Create > Material_. This makes a new material in the Project pane.

   __a.__ Rename this material to _Mat_Leaves_.

   __b.__ Drag the _Mat_Leaves_ material from the Project pane onto _Leaves_ in the scene or Hierarchy pane.

   __c.__ Select _Mat_Leaves_ in the Project pane again.

   __d.__ In the Inspector for Mat_leaves, set the _Albedo_ color under _Main Maps_ to a leafy-looking green

   __e.__ In the Inspector for Mat_Leaves, set the Smoothness slider to 0 (zero). This eill reduce the _specular highlight_ (which is the bright reflection of the sun on the surface of a shiny object).

   __2.__ From the menu bar, choose _Assets > Create> Material_ to create a second material.

   __a.__ Name this second material _Mat_Wood_.

   __b.__ Drag _Mat_Wood_ onto _Trunk_ in either Hierarchy or Scene pane.

   __c.__ Set the _Albedo_ color of Mat_Wood to a tree-like brown.

   __d.__ Adjust the Metallic and Smoothness sliders for texture

   __3.__ Dragg _AppleTree_ from the Hierarchy pane over to the Project pane to make a prefab from it

   __4.__ To move AppleTree up and out of the way a bit, select _AppleTree_ in the HIerarchy and change its position to P:[0, 10, 0]

   __5.__ At the top of the Scene pane, click the button labled "2D". This will orient the Scene view with the X axis pointing to the right, the Y axis pointing upward, and the Z axis pointing away towards teh horizon. This aligns the view of the Scene pane with the view of the Main Camera GameObject (and the image that the camera shows in the Game pane).

   __6.__ Click th eEffects buttin at the top of the Scene pane to deslect it. The effects button looks like a stack of two layers and a star (Please click the icon itself to turn all effects off rather than clicking the down arrow, which gives a pop-up menu listing each effect)

   __7.__ Save the scene.

* __Apple__

   __1.__ From the menu bar, choose _GameObject > 3D Object > Sphere_.
   
   __2.__ Rename this sphere _Apple_.
   
   __3.__ To quickly reset the Transform of the Apple GameObject, select _Apple_ in the Hierarchy, and then click the three vertical dots in the top-tight corner of the Transform component in the Inspector pane for the Apple. Choose _Reset_ from the three-dot pop-up menu, and it will reset the transform of th eApple to:
   * P:[0, 0, 0]
   * R:[0, 0, 0]
   * S:[1, 1, 1]
   
   __4.__ Create a new material named _Mat_Apple_ and set its _Albedo_ color to a bright red.
   
   __5.__ Drag _Mat_Apple_ onto Apple in the Hierarchy.

* __Adding Physics to the Apple__

   __1.__ Select Apple in the Herarchy pane. From the Unity menu bar, choose _Component > Physics > Rigidbody_.
   
   __2.__ Click the Unity _Play_ button, and the Apple will fall off the screen due to gracity.
   
   __3.__ Click the _Play_ buttong again to stop playback, and the Apple will return to its start locaton.

* __Giving Apples the Tag "Apple"__

   __1.__ Select Apple in the Hierarchy, click the pop-up menu button next to Tag (that currently displays _Untagged_) and choose _Add Tag..._ from the pop-up menu. This opens Unity's Tags & Layers Manager in the Inspector.
   
   __2.__ Click the __+__ symbol to add a new tag.
   
   __3.__ Type _Apple_ into the _New Tag Name_ field and click _Save_.
   
   __4.__ Click _Apple_ in the Hierarchy again to return to the Inspector for Apple.
   
   __5.__ Clicking the Tag pop_up menu once more gives _Apple_ as a tag option (at the end of the list; these options are not alphabetically sorted). Choose _Apple_ from the list of tags. Apple GameObjects will have the tag _Apple_, which makes them easier to identify and select

* __Making the Apple into a Prefab__

   __1.__ Drag Apple from the Hierarchy pane to the Project pane to make it a prefab.
   
   __2.__ After Apple prefab is in the Project pane, click the _Apple_ instance in the Hierarchy pane and delete it (by choosing Delete from th right-click menu). Because the apples in the game will be instantiated from the Apple prefab in the Project pane, the game chould not start with an Apple in the Hierarchy
   
   __3.__ Save the scene.

* __Basket__

   __1.__ Choose _GameObject > 3D Object > Cube_ from the Unity menu bar
   
   __a.__ Rename Cube to _Basket_.
   
   __b.__ Set the _transform_ of Basket to the following:
   * P:[0, 0, 0]
   * R:[0, 0, 0]
   * S:[4, 1, 4]
   
   __2.__ Create a new material named _Mat_Basket_.
   
   __a.__ In the Mat_Bakset Inspector, set its _Albedo_ color to a light, desaturated yellow (like straw)
   
   __b.__ At the top of the Mat_Basket Inspector, set the _Shader_ to _Unlit > Color_ (which will appear in the Inspector as _Unlit/Color_ after you choose it).
   
   __C.__ Apply the Mat_Basket material to the Basket.
   
   __3.__ Add a Rigidbody component to Basket. Select _Basket_ in the Hierarcy and choose _Component > Physics > Rigidbody_ from the Unity menu
   
   __a.__ In Basket's Rigidbody Inspector, set _Use Gravity_ to false (unchecked).
   
   __b.__ In Basket's Rigidbody Inspector,set _Is Kinematic_ to true (checked).
   
   __4.__ Make Basket a prefab by dragging _Basket from teh Hierarchy pane to the Project pane and deleting the remaining instance of Basket from the Hierarchy (just as for Apple).
   
   __5.__ Save scene.



### Camera Setup
__1.__ Select _Main Camera_ in the HIerarchy pane and ensure that its _transform_ is set as follows:
* P:[0, 0, -10]
* R:[0, 0, 0]
* S:[1, 1, 1]

__2.__ In the Camera component of the Inspector, set the following

   __a.__ Set the _Projection_ from Perspective to _Orthographic_.

   __b.__ Set the _Size_ to _16_ (Size only appears for orthographic cameras).


### Game Panel Settings
__1.__ Click the _aspect ratio_ pop-up menu

__2.__ Choose _Full HD (1920x1080)_ from the menu.


## Coding the _Apple Picker_ Prototype
__1.__ First, create a ne C# script named _AppleTree_ and add it to the AppleTree prefab.

   __a.__ Select _AppleTree_ in the Project pane (not the one in the Hierarchy).

   __b.__ Click the _Add Component_ button near the bottom of the Inspector for AppleTree (Prefab Asset).

   __c.__ Type _AppleTree_ in the sear field that pops up and then click _New Script_. New Script pop-up with the name of the new script preset to _AppleTree_.

   __d.__ CLick _Create and Add_ at the bottom og the NEw SCript pop-up. This dos two things:
   * It creates a C# script named AppleTree.cs in the Assets folder of the Project pane.
   * And it attaches that AppleTRee script as a component of the AppleTree prefab.

__2.__ Open the AppleTree script in VS and enter code to match

```ruby
   using System.Collections;
   using System.Collections.Generic;
   using UnityEngine;
   
   public class AppleTree : Monobehaviour {
      [Header("Inscribed")]
      // Prefab for instantiating apples
      public GameObject applePrefab;
   
      // Speed at which the AppleTree moves
      public float speed = 1f;
   
      // Distance where AppleTree turns around
      public float leftAndRightEdge = 10f;
   
      // Chance that the Apple Tree will change directions
      public float changeDirChance = 0.1f;
   
      // Seconds between Apples instantiations
      public float appleDrpoDelay = 1f;
   
      void start() {
         // Start dropping apples
      }
   
      void Update() {
         // Basic Movement
         // Changing Direction
      }
   }
```

__3.__ Save the _AppleTree_ script to VS and return to Unity

__4.__ Select the _AppleTree_ in the Hierarchy pane (not the Project pane).

__5.__ Try moving the AppleTree around in the scene by adjusting the X and Y corrdinates in the Transform Inspector to find a good height (position.y) for th eAppleTree and a good limit for left and right movement

   __a.__ Set the position of AppleTree to P:[0, 11, 0]

   __b.__ Set the __leftAndRightEdge__ float in the _AppleTree (Script)_ component Inspector to _24_. this will overrrise the default value of t0 that's in the script.


### Applying  AppleTree Instance Overrides to the AppleTree Prefab
__1.__ Near the top of the Inspector, pop-up menu button labled _Overrides_.

   __a.__ Click the _Overrides_ button. The pop-up that appears shows everything that will be applied back to the prefaab version.

   __b.__ Click _Apply All_ to copy all AppleTree (SCript) settings to the prfab.


### Basic Movement
__1.__ Make the changes to the __Update()__ method in the AppleTree script

```ruby
   using System.Collections;
   using System.Collections.Generic;
   using UnityEngine;
   
   public class AppleTree : Monobehaviour {
      [Header("Inscribed:)]
      // Prefab for instantiating apples
      public GameObject applePrefab;
   
      // Speed at which the AppleTree moves
      public float speed = 1f;
   
      // Distance where AppleTree turns around
      public float leftAndRightEdge = 10f;
   
      // Chance that the Apple Tree will change directions
      public float changeDirChance = 0.1f;
   
      // Seconds between Apples instantiations
      public float appleDrpoDelay = 1f;
   
      void start() {
         // Start dropping apples
      }
   
      void Update() {
         // Basic Movement
         Vector3 pos = transform.position;
         pos.x += speed * Time.deltaTime;
         transform.position = pos;

         // Chainging Direction
      }
   }
```

__2.__ Save the script, return to Unity, and press _Play_.


### Changing Direction
__1.__ Modify the AppleTree script

```ruby
   using System.Collections;
   using System.Collections.Generic;
   using UnityEngine;
   
   public class AppleTree : Monobehaviour {
      [Header("Inscribed:)]
      // Prefab for instantiating apples
      public GameObject applePrefab;
   
      // Speed at which the AppleTree moves
      public float speed = 1f;
   
      // Distance where AppleTree turns around
      public float leftAndRightEdge = 10f;
   
      // Chance that the Apple Tree will change directions
      public float changeDirChance = 0.1f;
   
      // Seconds between Apples instantiations
      public float appleDrpoDelay = 1f;
   
      void start() {
         // Start dropping apples
      }
   
      void Update() {
         // Basic Movement
         Vector3 pos = transform.position;
         pos.x += speed * Time.deltaTime;
         transform.position = pos;

         // Chainging Direction
         if (pos.x < - leftAndRightEdge) {
            speed = Mathf.Abs(speed);      // Move right
         }
         else if {
            speed = -Mathf.Abs(speed);     // Move left
         }
      }
   }
```

__2.__ Save the script, return to Unity, and click _Play_.
