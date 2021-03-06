Game Framework - Free v3.1

Thank you for using Game Framework. 

This package features the main core of Game Framework. There is also an extras bundle in addition to 
this framework also contains a lot of useful additional content to get you up and running including:

	- 3 UI themes (Cartoon, Space, RPG)
	- The full Beautiful Transitions asset for beautiful screen and UI wipes and transitions
	- The full Pro Pooling asset for advanced gameobject pooling
	- The full Prefs Editor asset for managing your player prefs.
	- Full 2D runner framework and game sample.
	- Advanced parallex scrolling script.
	- Additional 3D models and animations including for free prize
	- Additional samples
	- Tutorials
	- Other content
	- Priority support and feature requests
	- Secures future development of this framework
	
Feel free to try this version, however if you like the framework then please consider the small 
price of purchasing the extras bundle to support our efforts in developing this framework further.

Our goal is to create something that you enjoy and want to use. If you have any thoughts, comments, suggestions or 
otherwise then please contact us through our website or drop me a mail directly on mark_a_hewitt@yahoo.co.uk

Please consider rating this asset on the asset store.

Regards,
Mark Hewitt

For more details please visit: http://www.flipwebapps.com/game-framework/ 
For tutorials visit: http://www.flipwebapps.com/game-framework/tutorials/

- - - - - - - - - -

QUICK START

	1. If you have an older version installed:
		1.1. Make a backup of your project.
		1.2. Delete the old /FlipWebApps folder to cater for possible conflicts.
		1.3. Import the new version.
		1.4. Try out the Demo scene for getting started information.

For full setup instructions visit: http://www.flipwebapps.com/game-framework/setup/		
		
- - - - - - - - - -

CREDITS

ConditionalHideAttribute & PropertyDrawer - by Brecht Lecluyse (www.brechtos.com)
EditorList - courtesy of catlikecoding.com
ColorHSV.cs - C.J. Kimberlin (http://cjkimberlin.com)
Portuguese and Spanish Translations - Bryan Jonson
French Translation -  Fabrice Pilet
Chinese Translation - luochuanyuewu
		
- - - - - - - - - -

CHANGE LOG

v3.1

This release contains rewritten Facebook functionality that breaks with the old API. If you used this before then 
you will likely need to make some changes. Please consult the documentation pages for what has changed. 
It is recommended to backup and then delete the old /FlipWebApps folder before updating. 

	Game Framework Core - Improvements
	- Display: Code cleanup, Tooltips and Documentation
	- Display: Added optional offset to CenterInCamera
	- Display: Added option to FixedMovement to move always or only when a level is running
	- Display: Added option to FixedRotation to rotate always or only when a level is running
	- Display: Added DisplayMetrics.IsSystemDpiAvailable()
	- Display: ObjectDestroyer trigger collision correctly adheres to the specified destroy mode.
	- Display: Added new LevelOfDetail component to replace deprecated LOD component
	- Display: Tooltips, comments and refactoring
	- Display: ColorHelper.ParseColorString() supports hex string without leading #
	- Display: ObjectDestroyer supports 3D colliders
	- Display: GradientBackgroundSplitMiddle component is now implemented and working
	- EditorExtras: Code comments, tooltips and cleanup.
	- FreePrize: Comments and Tooltips
	- Facebook: Major rewrite to improve and simplify usage
	- Facebook: ConnectButton component replaced by FacebookConnection
	- Facebook: Old events replaced by messaging system
	- GameFramework: Added startup help window
	- Game Framework: Added Facebook to the integrations window
	- GameObjects: Tooltips, Comments and Documentation
	- GameStructure: Added new DeviceOrientationChangedMessage and ResolutionChangedMessages
	- UI: Gameover updated for new Facebook API changes

	Game Framework Core - Fixes
	- UI: Fix for obsolete Assert in DialoigInstance being triggered in Unity 5.4

	Game Framework Tutorials (Extras Bundle) - Improvements
	- Display: Added Placement sample
	- Facebook: Added usage sample

v3.0

The main focus of this version is code cleanup and removal of obsolete code. It is recommended to backup and then delete 
the old /FlipWebApps folder before updating. If you have any problems or compile errors due to removed code then see the 
below release notes or visit our support forum for help.

	Game Framework Core - Improvements
	- Advertising: Added AdMob support
	- Advertising: Added AdMob ShowHideAdvert compontent
	- Advertising: Added UnityAds.ShowAdvert shortcut method
	- Advertising: Added ShowAdvert component to simply show Unity Adverts
	- Advertising: Updated comments, tooltips, help links and documentation page
	- Animation: Updated comments, tooltips, help links and documentation page
	- Animations: Removed deprecated score specific animations in favor of generic UI animations.
	- Audio: Updated comments, tooltips, help links and documentation page
	- Billing: Updated comments, tooltips, help links and documentation page
	- Billing: Removed deprecated event callbacks in favor of messaging system.
	- Debugging: Removed deprecated cheat functions component
	- Debugging: Updated comments, tooltips, help links and documentation page
	- Display: Removed redundant HexString() method from ColorHelper.
	- GameStructure: Added PlayerChangedMessage when the selected player is changed
	- Internal: Move all GameFramework internal classes to new scripts/GameFramework folder.
	- Localisation: Updated comments, tooltips, help links and documentation page
	- Localisation: Added EnableIfLanguage component
	- Localisation: Removed obsolete OnLocalise event in favor of messaging and LocalisationChangedMessage
	- Prefab: Removed deprecated Score/TotalCoins prefab
	- Preferences: Corrected namespace from ...Scripts.Integrations.Preferences to ...Scripts.Preferences
	- Preferences: Updated comments, tooltips, help links and documentation page
	- UI: Removed previously deprecated FadeLevelManager and ScoreDisplay classes
	- UI: All ShowValueAnimatedMessaging derived classes (e.g. ShowCoins etc..) now react to localisation changes

	Game Framework Core - Fixes
	- UI: Fixes for ShowValueAnimated Immediate mode
	- GameStructure: Assert check in GameManager for valid mainCamera

	Game Framework Tutorials (Extras Bundle) - Improvements
	- Animation: Added animated values sample
	
	BeautifulTransitions (Extras Bundle): Updated to v3.2 pre-release that includes:
	- Transition: Added option to specify the axis on which MoveTarget should work so you can easier move multiple items (see GameObjectTransitionsDemo)
	- Transition: Deprecated MoveTarget TransitionStep as the functionality is provided by Move (Note: MoveTarget component remains)
	- Transition: Updated tooltips

v2.5

	Game Framework Core - Improvements
	- Advertising: Improved AdMob support
	- EditorExtras: Added EditorHelper LinkButton() helper method
	- EditorExtras: Added PlayerSettingsHelper class for dealing with Player Settings.
	- Free Prize: Allow for persisting next free prize times across game restarts.
	- Free Prize: Added tool tips and source code documentation updates
	- General: Support for secure player prefs including migration of unsecured values (enable in GameManager).
	- GameOver: Added option for automatically updating the player score / coins from the level ones
	- GameStructure: Added option to enable encrypted preferences and provide password
	- Integrations: Added window for managing integrations with other assets
	- Localisation: Sends new LocalisationChanged message when the localisation changes.
	- Messaging: RunOnMessageAttribute added and RunOnMessage updated to be able to run at various lifecycle stages.
	- Preferences: Added support for replacement PlayerPrefs assets
	- Preferences: Added support for encrypted preferences

	Game Framework Core - Fixes
	- GameStructure: GameManager.IsUnlocked is correctly saved if set through code.
	- GameStructure: GameItem Buttons now listen for localisation changed messages.
	- GameStructure GameItem localised values retrieved when requested to avoid caching issues and allow for localisation changes.
	- Helper: Removed invalid Debug.WriteLine call used in certain builds.
	- WIndows Phone: Several updates to fix compile errors for Windows Phone
	
	Game Framework Extras (Extras Bundle) - Improvements
	- Various minor tutorial fixes

	Game Framework Tutorials (Extras Bundle) - Improvements
	- Free Prize: Removed use of deprecated ShowScore component.
	
	BeautifulTransitions (Extras Bundle): Updated to v3.1 that includes:
	- Demo: Added attention button to the DisplayItem demo scene
	- Demo: Shake demo updated with visual controls for modifying the shake settings
	- DisplayItem: Removed unnecessary DisplayItemSetInitialState component
	- DisplayItem: Added SetAttention and SetActiveAnimated functions to DisplayItemHelper.cs
	- General: Added links to documentation and support to the editor menu
	- Shake: Moved scripts from ShakeCamera to Shake folder and namespace.
	- Shake: Improved tooltip text for ShakeCamera component
	- Shake: Renamed Shake method to ShakeCoroutine and added new replacement Shake method that is callable from code.
	- Shake: Code documentation improved
	- Transitions: Updated component menu name
	- Transitions: Screen & Camera wipes now support smoothing.

	Prefs Editor (Extras Bundle): Updated to v2.0 that includes:
	- Support for encrypted player prefs including optional auto encryption of old unencrypted values

v2.4

NOTE: To update you will need to remove the old /FlipWebApps/BeautifulTransitions/ folder before updating, or delete the file 
/FlipWebApps/BeautifulTransitions/Scripts/Transitions/GameObject/TransitionMoveAnchoredPosition.cs after updating.

	Game Framework Core - Improvements
	- EditorExtras: Menu cleanup
	- GameStructure: Added OnLifeLostEnableGameobject component
	- Localisation: Added portuguese and spanish translations (Thanks to Bryan Jonson)
	- Localisation: French translation courtesy of Fabrice Pilet
	- Localisation: Added Chinese translation courtesy of luochuanyuewu.
	- Localisation: Support for specifying the language to get text for (rather than just the currently set one)
	- Messaging: Added description to all messages for display in message log.
	- Messaging: Improved Message Activity window including message details when an entry is selected
	- Messaging: Show call stack in message window detail view.
	- UI: Settings window shows the language with the localised name
	
	Game Framework Tutorials (Extras Bundle) - Improvements
	- Localisation: Updated tutorial for new languages
	- GettingStarted: Added getting started part 8 tutorial files as an extension of part 6-7
	
	BeautifulTransitions (Extras Bundle): Updated to v3.0 that includes:
	- Rewritten from the ground up to expose the whole API through scripting including calls and notifications.
	- GameObject: Removed deprecated TransitionMoveAnchoredPosition component
	- Demo: New scripting demo
	- Demo: Added auto transition in / out button to GameObject demo

	Prefs Editor (Extras Bundle): Updated to v1.0.1 that includes:
	- Fix for OSX path and key format

v2.3

	Game Framework Core - Improvements
	- All: Added all components to editor component menu and added editor help link
	- Debugging: Option to show all current player prefs
	- Debugging: Deprecated Cheat Functions component in favor of Cheat Functions Window
	- Debugging: Added star options to cheat functions window.
	- Debugging: Improved checks before showing level cheat options.
	- Display: Added Color HSV with Lerp support
	- EditorExtras: Added methods to quickly get new label styles
	- EditorExtras: Added ButtonTrimmed with texture
	- GameStructure: Changed GameItemsManager constructor to use MyDebug to avoid spamming the console
	- GameStructure: Option to give health bar a value specific color tint
	- GameStructure: Added DecreaseLivesWhenHealthIsZero component
	- GameStructure: Added StarsWonHandlerCoins and StarsWonHandlerScore components for coin and score based stars
	- GameStructure: Added several prefabs for Lives, Health and Stars
	- GameStructure: Added StarWon method for checking if a star is won.
	- GameStructure: Fix for IsStarWon not returning correct value.
	- GameStructure: Added StarIcon prefab
	- GameStructure: Record stars won before the level starts for later use
	- Messaging: Added statistics to the Messages Window
	- Messaging: Minor UI improvements for messages editor window
	- Sprites: Added default white rectangle and grey gradient sprites
	- UI: Added default show star condition to Game Over dialog
	
	Game Framework Core - Fixes
	- Debugging: Fix for double assign of health in cheat functions window
	- GameStructure: Changed update messaging from Trigger to Queue to allow existing messages to be processed first.
	- GameStructure: Fix for execution order in CreateStarIcons by changing Awake->Start
	
	Game Framework Extras (Extras Bundle) - Improvements
	- GameStructure: Added ShakeScreenWhenLivesLost component
	- Themes: Added several prefabs for Lives, Health and Stars
	- Themes: Added health bar images
	- Themes: Added white and grey gradient images

	Game Framework Extras (Extras Bundle) - Fixes
	- Scrolling: Corrected namespace
	- Themes: Updates to remove use of deprecated Beautiful Transitions components
	
	Game Framework Tutorials (Extras Bundle) - Improvements
	- GettingStarted: Added part 7 tutorial files as an extension of part 6
	
	Game Framework Tutorials (Extras Bundle) - Fixes
	- Various: Updates to remove use of deprecated Beautiful Transitions components

	Prefs Editor (Extras Bundle) - New asset now included in the extras bundle

v2.2.2

	Game Framework Core - Improvements
	- Billing: Seperated out product purchased code and exposed through Cheat Functions window for easy testing
	- Debugging: Support for specifying the debug level
	- EditorExtras: Fix for build error due to reference to UnityEditor
	- EditorExtras: Added namespace to ConditionalHideAttribute and Property Drawer.
	- EditorExtras: Added EditorHelper class with useful Editor related helper functions
	- GameStructure: Added IsInitialised property to GameManager.
	- GameStructure: Added DebugLevel option to GameManager settable through the inspector.
	- GameStructure: Added GameUnlockedMessage which is generated by GameManager IsUnlocked changes
	- GameStructure: Removed GameManager IsUnlocked from inspector as this can now be set through the cheat functions window.
	- GameStructure: Added EnableBasedUponGameUnlocked component
	- Messaging: Improved editor window

	Game Framework Core - Fixes
	- GameStructure: For for incorrect assertion
	- Messaging: Fix for error when building
		
	BeautifulTransitions (Pro Bundle): Updated to v2.3 that includes:
	- Editor: Simplified inspector UI
	- GameObject: Support for global and local rotations
	- GameObject: New TransitionMove component with support for global, local and anchored position values.
	- GameObject: Deprecated TransitionMoveAnchoredPosition in vavour of new TransitionMove component.	


v2.2.1

	Game Framework Core - Improvements
	- Billing: Updated to use new messaging functionality.
	- GameStructure: Added Player.IsGameWon property including GameWonMessage.
	- GameStructure: Added Game\GameHelper with various glabal gamestructure related functions.
	- GameStructure: GameItem specific bool setting support.
	- GameStructure: GameItem button uses messaging to get coin changes. 
	- GameStructure: GameItem improved completion unlock mode handling.
	- GameStructure: GameItem AddedGetNextItem functions
	- GameStructure: Added SafeAddListener and SafeRemoveListener shortcut methods to GameManager.
	- GameStructure: GameManager SafeQueueMessage and SafeTriggerMessage methods correctly check if the GameManager is active.
	- Messaging: Added basic message event log window.
	- UI: Start of support for new GameOver completion messages.
	
	Game Framework Core - Fixes
	- Billing: Fix for invalid call to constructor with 1 argument after v2.0 update.
	- GameStructure: corrected (reduced) unlock delay in LevelUnlockButton
	- UI: Incorrect naming caused IOS builds to break in OnButtonCLickLoadUrl
	
	Game Framework Extras (Pro Bundle) - Improvements
	- Themes: Updated GameOver prefabs with new completion messages.
	

v2.2
	Game Framework Core - Improvements
	- Debugging: Cheat functions changed to tabbed window to give more space.
	- GameManager: Added SafeQueueMessage() and SafeTriggerMessage() as a shorthand so you don't need to check if GameManager is setup.
	- GameStructure: Moved StarsWon from GameItem to Level as it is unlikely to be needed elsewhere.
	- GameStructure: Level specific messaging overrides for changes to levels and coins.
	- GameStructure: GameItem messaging for changes to score, highscore and coins.
	- GameStructure: Added optional game over conditions to LevelManager including when lives = 0 and health = 0
	- GameStructure: Player messaging for changes to lives, health, score, highscore and coins.
	- GameStructure: Added Player ShowHealth, ShowCoins, ShowHealthImage, ShowHighScore, ShowPlayerIngo, ShowScore.
	- GameStructure: Added Level CreateStarIcons, EnabledBasedUponNumberOfStarsWon, ShowLevelCoins, ShowLevelHighScore, ShowLevelScore components, 
		and added messaging for Coins, HighScore, Score and Stars Won changes.
	- GameStructure: Changed all Level and Player Showxxx() methods to react to messaging rather than relying on update loops and continual polling.
	- Messaging: Added Dummy message and RunOnMessage abstract component for simply taking an action on a message.
	- UI: Deprecated FadeLevelManager and ScoreDisplay in favour of better alternatives.
	- UI: Added ShowValueAnimatedMessaging abstract class to show a (optionally animated) value based upon a message notification

	Game Framework Core - Fixes
	- Various minor namespace and spelling corrections
	- RunOnmessage correctly checks if GameManager is active before removing listener.

	Game Framework Tutorials (Pro Bundle) - Improvements
	- Demo: All demos updated for new notification based ShowXXX GameStructure components
	
	BeautifulTransitions (Pro Bundle): Updated to v2.2 that includes:
	- Exposed Transition Start and Complete events through the inspector so you can easily hook up other code.
	- Demo: Added Events Demo
	- Demo: Added SceneSwap Demo
	- Fix for shaders sometimes missing from final build.


v2.1

IMPORTANT NOTE: We changed the GameManager Auto Create Levels option to false. If
you suddently find that your levels aren't showing then you may need to enable this
option on your GameManager component! 

	Game Framework Core - Improvements

	- Demo: Updated to show v2.0+ features.
	- Editor: improved editor list control with box and text overrides
	- GameStructure: GameManager default to not auto creating levels and setting player lives to 3
	- GameStructure: Added CreateLivesIcons component and life icon prefab. Assert for GameManager in all life components
	- GameStructure: ShowLives component for showing number of lives with optional animated changes.
	- Messaging: Added global messaging system
	- UI: New ShowValueAnimated base class with sample animations

		
	Game Framework Extras (Pro Bundle) - Improvements
	
	- Themes: Various display improvements on all themes.
	- Themes: Added life prefabs and icons.

	
	Game Framework Extras (Pro Bundle) - Fixes
	
	- GameStructure: Fix for animated particles not showing on level unlock.
	- Scrolling: Updates for pro pooling api changes.

	
	Game Framework Tutorials (Pro Bundle) - Improvements
	
	- GameStructure: Moved level resource images to samples where they are used
	- Tutorials: Updated Getting Started Part 6 - Visual improvements and navigation fixes
	- 2DInfinateRunner: Added camera shake on crash

	
	Game Framework Tutorials (Pro Bundle) - Fixes
	
	- Getting Started Tutorials: Various visual improvements and fixes

	
	BeautifulTransitions (Pro Bundle): Updated to v2.1.1 that includes:

	- Shake Camera: Added ShakeCamera component and shake helper for shaking other gameobjects.
	- Code refactor improvements (some shared script files moved to the Helper folder)
	- Under certain build conditions the shaders would not be included. Moved shaders to a 
	resources folder and improved load validation.

	
	Pro Pooling (Pro Bundle): Updated to v1.1 that includes:
	NOTE: This version contains some minor API changes needed to improve the functionality. 
	You may need to make a couple of small code changes. See below for details.	

	- New graphical demo showing generics, and delegated pool returns.
	- PoolItem lifecycle methods renamed - prefixed with 'On'
	- Added IReturnToPool interface with reference in PoolItem and ReturnSelf() method.
	- Pool - some items reworked around PoolItem to enable delegated references.
	- Added custom pool inspector.


v2.0

IMPORTANT NOTE: This version includes some unavoidable breaking changes to allow 
for supporting new features. You might need to reconfigure some items or perform 
minor code changes. In particular the number of automatically created levels on 
GameManager may need re-entering. You should also first make a backup and then 
delete the old /FlipWebApps/ directory before importing. See below for further details.

	Game Framework Core - Improvements

	- Debugging: Added DrawGizmoRect() method to MyDebug.cs
	- Debugging: Options for handling worlds in Cheat Functions window.
	- Display: GradientBackground lets you specify the top and bottom y position for finer control.
	- EditorExtras: Added HelpBox Decorator drawer
	- EditorExtras: Added custom EditorList - courtesy of catlikecoding.com
	- GameObjects: Added documentation and Random(), IsWithinRange() and Overlap() functions to MinMax.cs
	- GameObjects: Custom MinMax property drawer
	- GameStructure: GameOver method added to LevelManager
	- GameStructure: Added character and world button prefabs
	- GameStructure: Refactor of Game Structure Code.:
		- Simplified access to extended json configuration data from automatic setup mode without needing to create subclasses.
		- Better support for world and character menus and management.
		- Removed need for Level and World GameItemManagers.
		- Updated constructor and instantiating of GameItems.
		- Unlock world buttons.
		- World button sets correct levels if in auto setup mode
		- Localisation for world and character unlock and purchase
	- GameStructure: Reworked Auto Level setup:
		- Option for auto setup of worlds and characters. 
		- Custom inspector. 
		- Tooltips
	- GameStructure: Added Show(Character/Level/World) info component with optional localisation
	- GameStructure: Player lives support:
		- Set default on GameManager
		- Lives per player
		- Buttons in Cheat Functions window
		- Components to reset lives
		- Component to display life icons based upon lives.
	- GameStructure: GameItem - CustomInitialisation virtual method to allow an easy way for sub classes to do initialisation.
	- GameStructure: Level star targets with automatic setting from json configuration.
	- UI: Added option to specify continue screen for GameOver dialog.

		
	Game Framework Core - Fixes
	
	- changed ".tag ==" to ".CompareTag()" for performance in all instances
	- Weighting: Moved weighting framework to top level as it isn't tied to gamestructure.

	
	Game Framework Extras (Pro Bundle) - Improvements
	
	- GameStructure: Added Character and World Buttons to all themes.
	- Scrolling: ParallaxLayer and Parallax Items updated to use the new bundles Pro Pooling asset (see below)
	- Scrolling: Support for weighting and child instance specific spacing

	
	Game Framework Extras (Pro Bundle) - Fixes
	
	- General cleanup and code refactor.

	
	Game Framework Tutorials (Pro Bundle) - Improvements
	
	- Full 2D Infinite Runner Framework: Various updates and improvements.
	- Getting Started Tutorials: Various updates and improvements.
	- Getting Started Tutorials: Added new 'Getting Started Part 6 - Worlds' tutorial.

	
	Game Framework Tutorials (Pro Bundle) - Fixes
	
	- All demos and tutorials updated for latest framework changes
	- General cleanup and minor fixes.

	
	BeautifulTransitions (Pro Bundle): Updated to v2.0 that includes:

	- All previous transition curves are now built in, removing the dependency on iTween and giving improved performance.
	- Updated inspector gui with visual curves.
	- Code refactor improvements (if you experience any build errors with your own derived classes that you don't know how to fix then let us know)
	- Various fixes (see seperate 'Readme - Beautiful Transitions.txt' for full details)

	
	Pro Pooling (Pro Bundle): The Pro Bundle now includes Pro Pooling v1.0
	
	- Now included in the pro bundle.

v1.3
	Game Framework Core - Improvements
	- BeautifulTransitions: Updated to v1.2 that includes:
		- New Rotate UI / Game Object transition. 
		- Transition core code refactor.
		- Added the ability to define your own animation curves.
		- Added Custom Property Editor for improved UI and additional help. 
		- Various fixes (see seperate 'Readme - Beautiful Transitions.txt' for full details)
	- Display: Added SetQuadUVs
	- Editor: Added Conditional Hide property drawer (thanks to Brecht Lecluyse -  www.brechtos.com). 
	- Editor: Moved Editor files to allow better grouping
	- GameObjects: Added MinMax and MinMaxf structures.
	- GameStructure: Added Weighting framework for managing relative object weights over distance / time 
	  and selection of items based upon this. Usage will be demoed in a full infinate scroller game template in the 
	  paid version.
	- GameStructure: Allow specifying of an optional game item specific scene from game item button (e.g. for level).
	- Input: New shared OnMouseClickOrTap base class.
	- UI: Improvements for dialog swapping / transitioning
	- UI: Added OnButtonClickSwapDialogInstance and OnMouseClickOrTapSwapDialogInstance components.

	Game Framework Core - Fixes
	- UI: DialogInstance IsShown state correctly reflects active value

	Game Framework Extras (Paid Version Only) - Improvements
	- Scrolling: Added Scrolling script including manual / automatic scene setup, pooling and reuse of display instances, 
	auto scroll of follow camera, parallex support, for automatic scene setup - relative weightings for displayed gameobjects given 
	distance or time.

	Game Framework Tutorials (Paid Version Only) - Improvements
	- The start of what will be a full 2D infinate scrolling game template with tutorials. (work in progress)

v1.2
	Game Framework Core - Improvements
	- Input: New shared OnMouseClickOrTap base class.
	- UI: Improvements for dialog swapping / transitioning
	- UI: Added OnButtonClickSwapDialogInstance and OnMouseClickOrTapSwapDialogInstance components.

	Game Framework Core - Fixes
	- UI: DialogInstance IsShown state correctly reflects active value

v1.1
	Game Framework Core - Improvements
	- Removed FadeLevelManager as more advanced screen wipes are supported through the bundled BeautifulTransitions asset (paid verions only)
	- Updated the bundled BeautifulTransitions asset to v1.0 that includes:
		- Rewritten core for easier extensibility
		- Added Screen transitions including fade and multiple wipe transitions
		- Added Camera transitions including fade and multiple wipe transitions
		- Added the possibility to create your own custom transitions by uploading a new Alpha texture
		- Added new demo for screen and camera transitions.
	- Updated Demo scene

	Game Framework Extras - Fixes
	- Dialog fixes for updated transitions

v1.0
	Game Framework Core - Improvements
	- Deprecated legacy UI animations and added support for Beautiful Transitions asset (included with paid version)
	- Basic Demo scene added
	- Animation: SetTriggerOnce and SetBoolOnce components for running animations one time
	- Audio: Effect audio effect pooling and simultaneous effect support.
	- GameObjects: Generic EnableOnce component

	Game Framework Core - Fixes
	- Free Prize: Time to Free Prize subscribes to localisation changes

	Game Framework Extras - Improvements
	- UI / Themes: Updated all dialogs to use the new Beautiful Transitions asset.
	- Themes: Basic RPG theme.
	- Themes: Start of basic themes window to help with rebranding.

	Game Framework Extras - Fixes
	
	Game Framework Tutorials - Improvements
	- Advanced 'Extending Level' tutorial added
	- Updated all tutorials to use the new Beautiful Transitions asset.

	Game Framework Tutorials - Fixes

v0.9
	Game Framework Core - Improvements
	- IAP: Component to show / hide gameobjects depending upon whether IAP is enabled.
	- IAP: Support for full game unlock and unlocking of worlds and characters.
	- UI: Dynamic layout support for game over and settings windows.
	- UI: Support for chosing what is shown in game over and settings windows.
	- UI: Sync of button state changes to child text and image components for simpler and improved UI designs
	- Localisation: Language change notification.
	- Localisation: Dynamic settings option for choosing language.
	- Localisation: Button for choosing localisation language.
	- Localisation: Menu option for creating localisation file.
	- Localisation: Norwegian translation added.
	- Game Structure: Manual / automatic world select screen functionality.
	- GameObjects: RunOnState periodic frequency option.
	- GameObjects: GetPath() method.

	Game Framework Core - Fixes
	- Localisation: Fix for missing last character in certain conditions
	- UI: Button components refactored into new location

	Game Framework Extras - Improvements
	- UI: Updated all theme dialogs for dynamic layout and options.
	- Themes: Basic RPG theme.
	- Themes: Start of basic themes window to help with rebranding.

	Game Framework Extras - Fixes
	- UI: Removed old unlocklevel prefab content
	
	Game Framework Tutorials - Improvements
	- Dialog and Localisation tutorials

	Game Framework Tutorials - Fixes
	- Various fixes to several tutorials and bumped to newest prefabs.

v0.8.5
	Game Framework Core - Improvements
	- Animated score prefab
	- Support for animated dialog content
	- Support and enhancements for GameItem unlocking
	- Added free prize buttons to cheat window.
	- Score change animation support
	- GameObjectHelper GetParentNamedGameObject()

	Game Framework Core - Fixes
	- Fixed for incorrect conditional includes
	
	Game Framework Extras - Improvements
	- Added space theme and tutorial
	- New free prize 3D models and tutorial
	- Support for animated dialog content
	- Animated unlock functionality

	Game Framework Extras - Fixes
	- Fixes in several tutorial samples

v0.8
	First public release