## CHAT BOT CREATION TUTORIAL 2020

In this model I have created a basic AI Interface with External plugin abilities; An Interface AI_Contracts enables for Intefacing with the AI; Implementing the Interface and placing in the the compiled DLL into the APP\Plugins folder enables for the AI_Interface to discover and call the plugin obtaining a response to be returned to the user; The project was design in 4 stages ; Each stage or milestone enables for the development and extension of the Chatbot to become a enriched product worthy of public release; 

## STAGE 1 - Designing and building the interface:

Here the interface is given a basic design for input and output via text; 
Maintaining history of the CHAT; this interface enables for the basic testing of the interface; An avatar has not been added; this is also due to the avatar not being essential but cosmetic; The first stage we focus mainly on producing a functional interface;

### AI_CONTRACTS: 
This is the mechanisim where we will enable for the USER to design scripts which can be executed b the AI; In the begining stage; PRoviding the mecanisim is the key focus. the intial Interface used Only provides the structure of the class needed to be implemented; the user function will be called by the main script for all objects of this type found at the specified location. this enables for extensive extenability. Here is also a point of which Extensions and Internal functions or an AI framwork can be provided to the user for use as helper scripts.

In the first Release of the AI a sample plugin will also be created to enable for testing of the interface. SAMPLE_PLUGIN this will also provide a template for further plgin creation; 

## STAGE 2 -Creating an internal memory -:
At this stage we create an internal memory function, by providing a Question and Answer database. here Simple Question and Answer style responses can be created giving a starting point for users of the Application. Although there are implementations where each Turn is saved to the database. in this iteration it is chosen to be more focused towards a SUPERVISED Method. A database Editor will need to be provided. Yet this will be provided at a later stage; The Order of execution will be PLUGINS First then Question and Answer Second Allowing for the prioritizing of response discovery.  
