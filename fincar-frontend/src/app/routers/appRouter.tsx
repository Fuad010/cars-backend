import { createBrowserRouter, Navigate } from "react-router-dom";
import { Layout } from "app/layout";
import { Home } from "pages/home";
import { CarDetails } from "pages/car-details";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <Layout/>,
        children: [
            {
                index: true,
                element: <Navigate to="/home" replace />
            },
            {
                path: '/home',
                element: <Home />
            },
            {
                path: "auto/:id",
                element: <CarDetails />
            },
            {
                path: "dashboard",
                element: <>Dashboard</>
            }
        ]
    }
])