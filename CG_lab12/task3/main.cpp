#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <Windows.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\glew.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\wglew.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\glut.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\freeglut.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\SOIL.h>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\glm\glm.hpp>
#include <C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\include\GL\glm\gtc\matrix_transform.hpp>
#include <string>
#include <vector>
#include <fstream>

using namespace std;

//-----------------------------SHADER_MODE
//-------------------------- 0 - oneTexture, 1 - mix with Color, 2 - twoTextures
int shader_mode = 2;

//-----------------------------FACTOR MIX
float factor = 0.2f;

//-----------------------------TEXTURES

string texPath1 = "textures/Krushochki.bmp";
string texPath2 = "textures/road.bmp";
//string texPath3 = "C:\\Users\\mxeni\\OneDrive\\Рабочий стол\\Task 3\\textures\\4nqnbO1WtYI.jpg";
//string texPath4 = "C:\\Users\\mxeni\\OneDrive\\Рабочий стол\\Task 3\\textures\\-7gVNnL9cbM.jpg";
//string texPath5 = "C:\\Users\\mxeni\\OneDrive\\Рабочий стол\\Task 3\\textures\\Apo7X-181005-291.png";
//string texPath6 = "C:\\Users\\mxeni\\OneDrive\\Рабочий стол\\Task 3\\textures\\Apo7X-181008-96112.png";
//string texPath7 = "C:\\Users\\mxeni\\OneDrive\\Рабочий стол\\Task 3\\textures\\Apo7X-181018-59.png";





///----------------------------------------------------------------------------
GLuint textureID;
GLuint textureID1;
void _LoadImage() {
	textureID1 = SOIL_load_OGL_texture(texPath1.c_str(), SOIL_LOAD_AUTO, SOIL_CREATE_NEW_ID, 0);
	textureID = SOIL_load_OGL_texture(texPath2.c_str(), SOIL_LOAD_AUTO, SOIL_CREATE_NEW_ID, 0);
}

string vsPath = "shaders/vertex.shader";
string fsPath1 = "shaders/fragment_oneText.shader";
string fsPath2 = "shaders/fragment_mixColor.shader";
string fsPath3 = "shaders/fragment_twoText.shader";

int w, h;
GLuint Program;

string loadFile(string path) {
	ifstream fs(path, ios::in);
	if (!fs) cerr << "Cannot open " << path << endl;
	string fsS;
	while (getline(fs, fsS, '\0'))
		cout << fsS << endl;
	return fsS;
}

void checkOpenGLerror() {
	GLenum errCode;
	if ((errCode = glGetError()) != GL_NO_ERROR)
		cout << "OpenGl error! - " << gluErrorString(errCode);
}

void initShader() {
	string _f = loadFile(vsPath);
	const char* vsSource = _f.c_str();

	GLuint vShader, fShader;

	vShader = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(vShader, 1, &vsSource, NULL);
	glCompileShader(vShader);

	if (!shader_mode)
		_f = loadFile(fsPath1);
	else if (shader_mode == 1)
		_f = loadFile(fsPath2);
	else
		_f = loadFile(fsPath3);

	const char* fsSource = _f.c_str();

	fShader = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(fShader, 1, &fsSource, NULL);
	glCompileShader(fShader);

	//----

	Program = glCreateProgram();
	glAttachShader(Program, vShader);
	glAttachShader(Program, fShader);

	glLinkProgram(Program);
	int link_ok;
	glGetProgramiv(Program, GL_LINK_STATUS, &link_ok);
	if (!link_ok) { std::cout << "error attach shaders \n";   return; }

	checkOpenGLerror();
}

void freeShader() {
	glUseProgram(0);
	glDeleteProgram(Program);
}

void resizeWindow(int width, int height) { glViewport(0, 0, width, height); }

GLuint vertexbuffer;
GLuint colorbuffer;
GLuint texturebuffer;

void initVBO() { //Загрузить в шейдерыы данные на видеокарту
	GLuint VertexArrayID;
	glGenVertexArrays(1, &VertexArrayID); // Синхронизирует все буферы в один объект
	glBindVertexArray(VertexArrayID); //Работает с буферами, которые идут дальше
	static const GLfloat g_vertex_buffer_data[] = {
		-1.0f,-1.0f, 1.0f,
		-1.0f, 1.0f, 1.0f,
		1.0f, 1.0f,-1.0f,
		1.0f, 1.0f,-1.0f,
		1.0f,-1.0f,-1.0f,
		-1.0f,-1.0f, 1.0f,
	};

	static const GLfloat g_color_buffer_data[] = {
		0.0f,  1.0f,  1.0f,
		0.0f,  1.0f,  1.0f,
		0.0f,  1.0f,  1.0f,
		0.0f,  1.0f,  1.0f,
		0.0f,  1.0f,  1.0f,
		0.0f,  1.0f,  1.0f,
	};

	static const GLfloat g_uv_buffer_data[] = {
		0,0,
		0,1,
		1,1,
		1,1,
		1,0,
		0,0,
	};

	glGenBuffers(1, &vertexbuffer);
	glBindBuffer(GL_ARRAY_BUFFER, vertexbuffer);
	glBufferData(GL_ARRAY_BUFFER, sizeof(g_vertex_buffer_data), g_vertex_buffer_data, GL_STATIC_DRAW); // Указатель на данные (загрузка, когда надо)

	glGenBuffers(1, &colorbuffer);
	glBindBuffer(GL_ARRAY_BUFFER, colorbuffer);
	glBufferData(GL_ARRAY_BUFFER, sizeof(g_color_buffer_data), g_color_buffer_data, GL_STATIC_DRAW);

	glGenBuffers(1, &texturebuffer);
	glBindBuffer(GL_ARRAY_BUFFER, texturebuffer);
	glBufferData(GL_ARRAY_BUFFER, sizeof(g_uv_buffer_data), g_uv_buffer_data, GL_STATIC_DRAW);
}

void render1() {
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glm::mat4 Projection = glm::perspective(glm::radians(45.0f), 4.0f / 3.0f, 0.1f, 100.0f);
	glm::mat4 View = glm::lookAt(
		glm::vec3(4, 3, 3),
		glm::vec3(0, 0, 0),
		glm::vec3(0, 1, 0)
	);
	glm::mat4 Model = glm::mat4(1.0f);
	glm::mat4 MVP = Projection * View * Model;

	glUseProgram(Program); //подцепляем шейдерную программу

	glEnableVertexAttribArray(0); //Связывает буфер с айдишником входного параметра
	glBindBuffer(GL_ARRAY_BUFFER, vertexbuffer);
	glVertexAttribPointer(
		0, //id
		3, //кол-во
		GL_FLOAT, // Тип
		GL_FALSE, 
		0,
		(void*)0
	);

	glEnableVertexAttribArray(1);
	glBindBuffer(GL_ARRAY_BUFFER, texturebuffer);
	glVertexAttribPointer(
		1,
		2,
		GL_FLOAT,
		GL_FALSE,
		0,
		(void*)0
	);

	glEnableVertexAttribArray(2);
	glBindBuffer(GL_ARRAY_BUFFER, colorbuffer);
	glVertexAttribPointer(
		2,
		3,
		GL_FLOAT,
		GL_FALSE,
		0,
		(void*)0
	);

	GLuint MatrixID = glGetUniformLocation(Program, "MVP"); // Запрашиваем по названию глобальную переменную "MVP"
	glUniformMatrix4fv(MatrixID, 1, GL_FALSE, &MVP[0][0]); // Заносим в MatrixId перменную MVP

	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, textureID);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);

	glUniform1i(glGetUniformLocation(Program, "myTextureSampler"), 0); // 0 - id

	if (shader_mode == 2) {

		glActiveTexture(GL_TEXTURE1);
		glBindTexture(GL_TEXTURE_2D, textureID1);
		glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
		glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);

		glUniform1i(glGetUniformLocation(Program, "myTextureSampler1"), 1); 

		glUniform1f(glGetUniformLocation(Program, "mix_f"), factor);
	}
	glDrawArrays(GL_TRIANGLES, 0, 12 * 3);

	glDisableVertexAttribArray(0); //Отвязать все данные(буферы) от шейдеров

	glFlush();

	glUseProgram(0); //Отвязать программу шейдерную

	checkOpenGLerror();

	glutSwapBuffers();
}

int main(int argc, char **argv) {
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DEPTH | GLUT_RGBA | GLUT_ALPHA | GLUT_DOUBLE);
	glutInitWindowSize(1000, 800);
	glutCreateWindow("Simple shaders");
	glClearColor(0, 0, 0, 0);
	glEnable(GL_DEPTH_TEST);
	glDepthFunc(GL_LESS);
	GLenum glew_status = glewInit();

	initShader();

	_LoadImage();

	initVBO();

	glutReshapeFunc(resizeWindow);
	glutDisplayFunc(render1);
	glutMainLoop();

	freeShader();
}