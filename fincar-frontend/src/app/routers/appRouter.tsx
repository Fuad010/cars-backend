import { createBrowserRouter, Navigate } from "react-router-dom";
import { Layout } from "app/layout";
import { Home } from "pages/home";
import { CarDetails } from "pages/car-details";
import { DashboardLayout } from "pages/dashboard";
import { DashboardSeeAllCars } from "pages/dashboard-see-all-cars/ui/dashboardSeeAllCars";
import { CreateCarForm } from "features/create-car-form";

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
                        element:<DashboardSeeAllCars />
                    },
                    {
                        path: "/dashboard/create-new-car",
                        element: <CreateCarForm />
                    }
                ]
            },
        ]
    }
])