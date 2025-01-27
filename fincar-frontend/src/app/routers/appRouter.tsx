import { createBrowserRouter, Navigate } from "react-router-dom";
import { Layout } from "app/layout";
import { Home } from "pages/home";
import { CarDetails } from "pages/car-details";
import { DashboardLayout } from "pages/dashboard";

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
                path: "/auto/:id",
                element: <CarDetails />
            },
            {
                path: "/dashboard",
                element: <DashboardLayout />,
                children:[
                    {
                        path:"/dashboard/see-all-cars",
                        element:<></>
                    },
                    {
                        path: "/dashboard/create-new-car",
                        element: <></>
                    }
                ]
            },
        ]
    }
])