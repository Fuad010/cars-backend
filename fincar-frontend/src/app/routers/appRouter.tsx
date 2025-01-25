import { createBrowserRouter, Navigate } from "react-router-dom";
import { Layout } from "app/layout";
import { Home } from "pages/home";

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
                path: ":id",
                element: <>car detail</>
            }
        ]
    }
])