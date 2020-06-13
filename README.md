## CHAT BOT CREATION TUTORIAL 2020

In this model I have created a basic AI Interface with External plugin abilities; An Interface AI_Contracts enables for Intefacing with the AI; Implementing the Interface and placing in the the compiled DLL into the APP\Plugins folder enables for the AI_Interface to discover and call the plugin obtaining a response to be returned to the user; The project was design in 4 stages ; Each stage or milestone enables for the development and extension of the Chatbot to become a enriched product worthy of public release; 

## STAGE 1 - Designing and building the interface:

Here the interface is given a basic design for input and output via text; 
Maintaining history of the CHAT; this interface enables for the basic testing of the interface; An avatar has not been added; this is also due to the avatar not being essential but cosmetic; The first stage we focus mainly on producing a functional interface;

### AI_CONTRACTS: Migrated to Nuget! SpydazWeb.AI.CONTRACTS 3.0
This is the mechanisim where we will enable for the USER to design scripts which can be executed b the AI; In the begining stage; PRoviding the mecanisim is the key focus. the intial Interface used Only provides the structure of the class needed to be implemented; the user function will be called by the main script for all objects of this type found at the specified location. this enables for extensive extenability. Here is also a point of which Extensions and Internal functions or an AI framwork can be provided to the user for use as helper scripts.

In the first Release of the AI a sample plugin will also be created to enable for testing of the interface. SAMPLE_PLUGIN this will also provide a template for further plugin creation; 
###Note: Small BUG!!!!!
 AI_Contracts.Dll needs to be deployed in Plugins Folder Alongside plugin? Relative Refferencing for plugin Seperation. When the plugin was in the same folder as the application the application tried to keep reading itself and crashing so the seperate foler was required; the MAN EXE also needs to acess the AI_Contacts DLL SO... 
### Solution :
Double Deployment!. 

## STAGE 2 -Creating an internal memory -:
At this stage we create an internal memory function, by providing a Question and Answer database. here Simple Question and Answer style responses can be created giving a starting point for users of the Application. Although there are implementations where each Turn is saved to the database. in this iteration it is chosen to be more focused towards a SUPERVISED Method. A database Editor will need to be provided. Yet this will be provided at a later stage; The Order of execution will be PLUGINS First then Question and Answer Second Allowing for the prioritizing of response discovery.  A Fallback response will also be required to handle any time the AI has no response;

## STAGE 3 - Designing A State Machine - Handling Emotion:
A state machine can provide a mechanizim to hold Emotional states ; In this iteration an interface has been used to provide a structure for emotional state objects; Each state is loaded in to the Handler; Emotions are detected each turn of the Script adjusting the currently held emotions positivly and negativly allowing for inteisification of emotions. Here a generic Response is given as emotional state is changed.  other forms of State can also be carried from turn to turn by using a state machine; Previous programming method often have utilized "traveling vairables" yet often replacing state to state with finite quotient values for emotioanal Skew. IE happy = 0.78 , SAD 0.23 ; this technique does not allow for intensity of emotion ; intensity of emotion is increased ie: happy is increased if happy is detected next turn; but reduced if the next emotion is just simply neutral. until the level of intesity has reduced to the value 0 which can change state to Neutral. 

## STAGE 4 - Designing and building the interface Compilers/Scripting/Editing:
### Compiler
The abilty to code and comile the plugin can be provided by the chatbot interface; here i have provided a Tabbed interface for creating plugins, the template we implemented in stage 1 is used to provide a starter example script for the user to edit and expand on. SAVE SCRIPT AND COMPILE SCRIPT are provided; 
### Data Editor
A Data editor to edit the Question and Answer files is also created for each table.


## STAGE 5 - Refactoring Code!: UI Enhancments!
### Refactoring
Here we will refactor the code arranging and extending the functionality to the UserScripting framework. 
The refactoring process and Commenting enables for later editing and refineing of the application; as well as provide understanding to the user; 
### UI
#### Speech
Speech will also be required to provide a Rich UI, Although Speech recognition has improved over time; It will be added mainly for Speech out. 
#### Graphics
Some Graphical Improvemnts and themeing will be added to the APP: (Perhaps LCARS _ Star trek Design!)

## Stage 6: AI_CONTRACTS to NUGET:
For the deployement and centralized access for the AI_Contracts Component: It was also decided to centralize the Library with NUGET as SpydazWb.AI.Contracts ; This enables for further updates to be centralized for plugin creation and optimal delivery :
At this point The AI_Contracts SourceCode has also been removed from the Project and ADDED as a NUGET refference assemblie; 
The AI_Contracts Project can now be developed Seperately from the UI and Plugins; Plugins may also be deployed as Nuget Packages on a centralized source seprately from Nuget; ie Centralized website!


