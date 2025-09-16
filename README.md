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

   __4.__ To move AppleTree up and out of the way a bit, select _AppleTree_ in the HIerarchy and change its position to P:[0,10,0]
