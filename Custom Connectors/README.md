# Custom connectors for Power Platform

Contains custom connector starter samples to showcase possible implementations.

## OpenAI public connector

Contains a custom connector YAML definition to selected OpenAI ML models, use Text completions and Text edits with available models and do image generation using DALL-E.
The connector uses the OpenAI API - see more info here: [OpenAI API Docs](https://platform.openai.com/docs/introduction/overview)

Contains the following operations that may be used in Power Automate and Power Apps:  
### List models
Get all available text and code completation as well as edit models currently available from OpenAI public API. See Figure 1
The output can be used as input to the "model" parameter for text completion and edit actions.  
The *Generate text using model* action uses this operation to dynamically load values into the model selection parameter - see Figure 2.

![Figure 1 - List models](http://placekitten.com/400/300)
![Figure 2 - Dynamically loaded models for model parameter](http://placekitten.com/400/300)  


## Generate text using model
Allows selection of an OpenAI ML model and generation of text using an input prompt.
### Parameters
- Completion model: Loaded dynamically from available models
- Input: The input starter text 
- Maximum tokens: Length of the output
- Number of completions: How many completions to generate
- top_p: A seeding value for randomness (can be ignored)

## Create text edits
Allows creation of text edits to a given input text with arbitrary instructions.  
### Examples
- Input: *What week is it?*, Instruction: *Translate to french*
- Input: *What wek is it?*, Instruction: *Correct spelling mistakes*
### Parameters
- Model: The model to use
- Text : Input text
- Instruction: Free text edit instructions
- Temperature: A measure of randomness of the outout - from 0.0 to 1.0

### Generate image using DALL-E
Genertes an image or images based on a natural language description. Outputs a public URL with the generated image

### Parameters
- Image description: Description of image


## Known issues
Not all return parameters have been fully captured in the response schemata.