📄 XPath & CSS Selectors + Page Object Model (POM)

This repository contains a structured collection of XPath and CSS Selectors along with their integration into the Page Object Model (POM) design pattern for scalable and maintainable test automation.

🚀 Overview

The goal of this project is to:

Practice and organize XPath and CSS selector strategies
Convert raw locators into reusable Page Object Models
Improve test readability, maintainability, and scalability


📂 Project Structure
├── locators/
│   ├── Locators.txt
│   ├── Locators_table.txt
│
├── pages/
│   ├── NavigationPage.py
│   ├── ProductPage.py
│   ├── LoginPage.py
│
└── README.md
🧠 Concepts Covered
1. XPath Selectors
Absolute vs Relative XPath
Functions:
contains()
starts-with()
text()
normalize-space()
Axes:
parent
child
following-sibling
ancestor
2. CSS Selectors
Basic selectors:
#id, .class
Attribute selectors:
[type="text"]
Combinators:
>, +, ~
Pseudo-classes:
:nth-child()
:first-child
3. Page Object Model (POM)

POM is a design pattern where:

Each web page is represented as a class
Locators are stored as variables
Actions are implemented as methods
