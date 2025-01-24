import { CarListPage } from "pages/car-list-page";
import { createBrowserRouter, Navigate } from "react-router-dom";
import { Layout } from "app/layout";

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
                element: <>home</>
            },
            {
                path: ":id",
                element: <>car detail</>
            }
        ]
    }
])