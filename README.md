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

### Task Instructions
- Choose one of the provided processUserData function implementations as the target for your AI-driven review:
   - [Javascript](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.js)
   - [C#](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.cs)
   - [Python](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.py)
   - [Java](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.java)
   - [Go](https://github.com/julia-dream/pr-review-using-role-prompting/blob/master/processUserData.go)
- Define Expert Roles and Analysis Focus 
   - Your prompt must instruct the AI to adopt the following three expert personas sequentially, providing an analysis from each viewpoint. The focus areas for each role could be `As an Experienced Developer`, `As a Security Engineer`, `As a Performance Specialist`.
- Creating the Prompt
  - The prompt must clearly instruct the AI to:
    - Take the provided code snippet as input.
    - Analyze it from each of the three specified expert perspectives (Developer, Security Engineer, Performance Specialist).
    - For each perspective, provide specific, actionable recommendations and observations to improve the code.
   
### Implementation and Testing
Implementation (Prompt Design):
- Write the role-based prompt based on the "Task Instructions." The prompt is the primary artifact you are creating.
Testing (Conceptual Verification):
- Evaluate AI Output: Assess if the AI's expected or actual response generated using your prompt:
   - Provides distinct and relevant feedback for each of the three roles.
   - Covers the specified focus areas for each role.
   - Offers actionable and specific recommendations, not just generic statements.
   - Aligns with the kind of in-depth analysis described in the "Expected analysis results" from the original problem description (e.g., identifying var usage for JS, data validation issues for security, array iteration inefficiencies for performance).
- Refine Prompt: If the expected output is lacking, iterate on your prompt to improve its clarity and effectiveness in guiding the AI.

### Deliverables
The complete and final text of the prompt you have designed. This prompt should be ready to be used with an AI model to analyze the selected processUserData code snippet.



