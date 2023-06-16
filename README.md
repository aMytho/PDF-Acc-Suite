# PDF-Acc-Suite
A dotnet application to help make PDFs accessible.

## Purpose

The main app to make PDFs accessible is Adobe Acrobat Pro DC. However, this app is full of bugs, inefficient workflows, and costs far too much for what is is. Additionally, there are little to no alternatives. While other PDF editors exist, none support accessibility options aside from a [CommonLook Plugin for Acrobat](https://commonlook.com/accessibility-software/pdf/) and a [cloud based](https://equidox.co/pdf-solutions/pdf-accessibility-software/) platform (Equidox). Both of these are valid options, but they don't list a price on their website. Not good!

You shouldn't need to pay a fee to make a document accessible. This project will help to fix that issue.

## Features

While the end goal is to remove Acrobat from the accessibility workflow entirely, we have a *long* ways to go. At the moment, the project focuses on removing the operations that take the most time.

- List Generation: Generates a proper list with all the required tags. Useful for when you have lists that were detected as individual paragraphs.
- Table Generation: Generates a proper table with a specified amount of rows and columns.

## Installation

At the moment, you must build the project yourself. I will switch to using Github Actions once I can confirm the product is stable.

## Usage

Drag a PDF to the upload button. Select your tool and make the changes. Once the tool is completed, press the save button.

## Keyboard Shortcuts

Nearly every button/action has a keyboard shortcut. Cutting down remediation time is the primary goal.

### Main Page
- U: Opens the upload dialogue. (You can also drag the file to the button or press it, whichever is more convenient)
- L: Opens the list generator.
- T: Opens the table generator.
- S: Saves the file (if a file has been uploaded)
- C: Cancel the changes. The target export file will be deleted. The input file is untouched.

### List Generator
- N: Focus the list item amount.
- L: Toggles the label checkbox.
- G: Generates the list.
- Escape: Exits the tool without the changes.

### Table Generator
- C: Focus the column amount.
- R: Focus the row amount.
- Escape: Exits the tool without the changes.

## Feature Requests

Let me know if you have any suggestions. This is just a side project to help myself at work, but anyone is welcome to suggest improvements or contribute directly!
