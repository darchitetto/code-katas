[String Calculator]((http://osherove.com/tdd-kata-1/) was bored from: [Roy Osherove](http://osherove.com/)

# READ BEFORE YOU START
- Do not read ahead; not even a single step
- Try to focus on one task/refactor at a time
	- We are not trying to get it "right" the first time
	- Learn to think incrementally
- Refactoring after each passing spec is not just encouraged, but something that should be happening
- Assume only valid inputs will be provided; no need to check/handle invalid input

# String Calculator

## Step 1: Create String Calculator
- Should contain a method: `int Add(string number)`
- The method can accept 0, 1, or 2 numbers only. Return their sum
- Numbers are delimited by a `,`
- Example input: `"", "1", "1,6"`

Start with the simplest case of an empty string, then move onwards to 1 and 2 numbers. **Remember** to refactor after each successfully passing spec.

## Step 2
Allow the `Add` method to handle an unknown number of numbers

## Step 3
Allow the `Add` method to handle new lines between numbers (in addition to commas).

- Valid: `"1\n2"`
- Invalid: `"1,\n"`

## Step 4
Support different delimiters. Delimiters are only allowed to be one character in length. To change the delimiter, the beginning of the string will contain a separate line of the supported delimiters for the add operation in the below format:

- `"//[delimiter]\n"`
- *Example:* `"//[;]\n1;2"` would yield a delimiter of `";"`

## Step 5
Calling the `Add` method with a negative number should throw an exception with text: `"negatives not allowed: "` with the negative numbers provided. If there are more than one negative number, then show them all in the exception message

## Step 6
Numbers larger than 1000 should be ignored, so 2 + 1001 = 2

## Step 7
Delimiters can be of any length with the following format:

- `"//[delimiter]\n"`
- *Example*: `"//\[***\]\n1***2***3"` should equal 6

## Step 8
Allow multiple delimiters (remember to maintain that length can be any number of characters)

- `"//[delimiter][delimiter]\n"`

## Step 9
Include logging abilities via: `ILogger.Write(message)`. Every time you call `Add`, the sum result should be logged to the logger. Exception messages are also logged.

## Step 10
When the logger throws an exception, then the string calculator should utilize a fallback logging mechanism. In these cases, it should log via an `IWebService.log(message)` with the exception message of the logger.

## Step 11
Every time `Add` is called, the string calculator should display the result summation in the console.
