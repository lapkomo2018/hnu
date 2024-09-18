package main

import (
	"html/template"
	"io"
	"net/http"

	"github.com/labstack/echo/v4"
)

type Template struct {
	templates *template.Template
}

func (t *Template) Render(w io.Writer, name string, data interface{}, c echo.Context) error {
	return t.templates.ExecuteTemplate(w, name, data)
}

func main() {
	e := echo.New()
	e.Renderer = &Template{
		templates: template.Must(template.ParseGlob("public/views/*.html")),
	}
	e.Static("/static", "public/static")

	e.GET("/", func(c echo.Context) error {
		return c.Render(http.StatusOK, "base", map[string]interface{}{
			"Name":       "Maksim Lapko",
			"Group":      "IPZs-24",
			"University": "HNU",
			"Project":    "Social Network Y",
		})
	})
	e.Logger.Fatal(e.Start(":8080"))
}
