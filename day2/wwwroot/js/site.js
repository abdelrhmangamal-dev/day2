document.addEventListener("DOMContentLoaded", function () {
    const buttons = document.querySelectorAll("button, .btn");

    buttons.forEach(button => {
        button.addEventListener("click", function () {
            this.style.transform = "scale(0.97)";

            setTimeout(() => {
                this.style.transform = "";
            }, 100);
        });
    });

    const inputs = document.querySelectorAll("input, textarea, select");

    inputs.forEach(input => {
        input.addEventListener("focus", function () {
            this.style.outline = "none";
        });
    });

    const alerts = document.querySelectorAll(".alert");

    alerts.forEach(alert => {
        setTimeout(() => {
            alert.style.opacity = "0";
            alert.style.transition = "opacity 0.5s ease";

            setTimeout(() => {
                alert.remove();
            }, 500);
        }, 4000);
    });
});