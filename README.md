# Visual Basic Windows Forms Application

This project is a simple Windows Desktop Application created using Visual Studio and Visual Basic. The application displays a popup message box with a custom message.

## Requirements

- Visual Studio (Community Edition or higher)
- .NET framework (any version supported by Visual Studio)

## Getting Started

### Prerequisites

- Download and install [Visual Studio](https://visualstudio.microsoft.com/downloads/) with the "Desktop development with .NET" workload.

### Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/your-username/your-repo-name.git
    cd your-repo-name
    ```

2. Open the project in Visual Studio:

    - Open Visual Studio.
    - Click on "Open a project or solution".
    - Navigate to the cloned repository folder and select the solution file (`.sln`).

### Building and Running the Project

1. In the Solution Explorer, open `Form1.vb` file.
2. Modify the `Form1` constructor to include the following code:

    ```vb
    Public Sub New()
        InitializeComponent()
        MsgBox("YourName here, this is my Slidely AI task")
    End Sub
    ```

    Replace `"YourName"` with your actual name.

3. Click the green "Start" button at the top of Visual Studio or press `F5` to run the project.
4. A window will open, displaying the message box with your custom message.

### Demonstration

#### Working Video

Below is a video demonstration of the project in action:

[![Working Video](path/to/your/video-thumbnail.png)](https://link-to-your-video)

*Note: Click on the thumbnail or the link to watch the video.*

#### Screenshot

Here is a screenshot of the application displaying the message box:

![Screenshot](path/to/your/screenshot.png)

## Usage

- This project demonstrates how to create a simple Windows Forms application in Visual Basic.
- It shows how to display a message box (`MsgBox`) on form load.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Make your changes and commit them (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by a task from Slidely AI.

## Contact

- For any questions or feedback, feel free to contact [Your Name](mailto:your.email@example.com).
