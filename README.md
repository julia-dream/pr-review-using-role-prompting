# 👥 Effective PR Review using Role Prompting

### AI Technique: Role Prompting
Role prompting is an AI technique that directs a model to adopt a specific persona, character, or expert perspective when generating a response or performing a task. By assigning the model a particular role—such as a seasoned security expert, an experienced senior software developer, a meticulous technical writer, or even a specific fictional character—we can elicit responses that are more specialized, contextually relevant, and aligned with the nuances of that chosen role.

**How it Works:**
When a role is assigned, the AI leverages its vast training data to simulate the knowledge, language style, and reasoning patterns associated with that role. For instance, if prompted to act as a "cybersecurity analyst," the model will prioritize information and perspectives related to security vulnerabilities, threat assessment, and mitigation strategies. This doesn't mean the AI *becomes* that expert, but rather it filters and focuses its output through the lens of the designated persona. The prompt essentially sets a strong contextual anchor, guiding the AI's generation process to produce content consistent with the specified role's typical concerns, priorities, and communication style.

**Benefits:**
*   **Improved Relevance and Specificity:** Tailors AI output to specific needs, making responses more targeted and actionable. Instead of generic advice, you get insights pertinent to the chosen perspective.
*   **Enhanced Multi-Faceted Analysis:** Allows for the examination of a problem or piece of code from diverse viewpoints (e.g., developer, security engineer, performance specialist), leading to a more comprehensive understanding and identification of a wider range of potential issues or improvements.
*   **Better Control Over Tone and Detail:** Helps shape the tone, complexity, and depth of the AI's response. A "technical writer" role might produce clearer, more accessible documentation, while a "lead architect" role might focus on high-level design considerations.
*   **Simulating Expertise:** Provides a way to tap into specialized knowledge areas, offering insights that might otherwise require consulting with human experts in various fields. This is particularly valuable for tasks requiring niche expertise.
*   **Increased Engagement and Creativity:** For certain applications, adopting a persona can make the interaction more engaging or unlock more creative problem-solving approaches.

**Example: Human Resources Scenario**

Imagine you have an existing draft of a company-wide communication about a new remote work policy and you want it reviewed. Using role prompting, you could ask the AI to analyze this draft from these perspectives:

*   **As an HR Director reviewing the draft:**
    *   Evaluate the clarity of the policy rationale, completeness of legal compliance statements, and potential impact on company culture.
    *   Assess if the tone is authoritative yet supportive.
    *   Check if responsibilities for both employees and managers under the new policy are clearly and accurately outlined.
*   **As an Employee Engagement Specialist reviewing the draft:**
    *   Analyze how the communicated policy might affect morale and work-life balance.
    *   Identify if the draft adequately addresses potential concerns about team cohesion and isolation, suggesting improvements.
    *   Ensure the tone is empathetic, encouraging, and fosters a sense of support.
*   **As a Legal Compliance Officer (within HR) reviewing the draft:**
    *   Scrutinize the draft to ensure the policy, as described, adheres to all relevant labor laws and regulations.
    *   Identify any potential legal risks, ambiguities, or omissions in the communication.
    *   Verify that the language used is precise, unambiguous, and correctly highlights critical legal aspects.

This technique is especially useful when expertise in a specific domain is required for a nuanced answer, or when a multi-faceted analysis of a problem is needed to ensure thoroughness.

### Task:
You've submitted code for review and received feedback that seems superficial. You need to use AI to get a deeper analysis of your code from different perspectives.

[Javascript](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.js) | 
[Python](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.py) | 
[Java](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.java),
[Go](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.go).

### Question:
What prompt using role instructions would you create to get a comprehensive analysis of this code from the perspective of different experts?

### Verification:
Compare your prompt with the expected answer:

#### Expected Role Prompt

```
Analyze the following JavaScript code from the perspective of three different experts:
As an experienced JavaScript developer, evaluate the code quality, efficiency, and adherence to modern JS standards.
As a security engineer, identify potential vulnerabilities and security issues in this code.
As a performance specialist, assess the code efficiency and suggest optimizations.
For each role, provide specific recommendations for improving the code in the respective aspect.

**Expected analysis results:**

**JavaScript Developer:**
- Usage of outdated var instead of let/const
- Application of modern array methods (map, filter) instead of for loops
- Use of template literals instead of concatenation
- Unnecessary use of ternary operator for boolean value

**Security Engineer:**
- Lack of user data validation
- Potential XSS vulnerabilities when processing user input
- Risks when saving unverified data to database

**Performance Specialist:**
- Inefficiency when working with large data arrays
- Multiple access to the same array elements
- Suggestions for using memoization or caching
```


