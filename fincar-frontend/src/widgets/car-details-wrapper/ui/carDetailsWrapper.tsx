import { CarDetailsNames } from 'entities/car/car-detail-names'
import styles from './carDetailsWrapper.module.css'
import { useParams } from 'react-router-dom';
import { carModel } from 'entities/car';
import { useEffect } from 'react';
import { Image, Skeleton } from 'antd';
import { observer } from 'mobx-react-lite';

export const CarDetailsWrapper = observer(() =>{
    const baseUrl = import.meta.env.VITE_API_BASE_URL.replace('/api','')
    const { id } = useParams<{ id: string }>();
    
    const { store: { getCar, car, isLoading, isExistCar } } = carModel;
    useEffect(() => {
        if (id) {
            getCar(id);
        }
    }, [id]);
    
    if (isExistCar || !id) {
        return (
            <div className={styles.wrapper}>
                <p>{`404 Not Found :(`}</p>
            </div>
        );
    }
    
    return(
        <div className={styles.wrapper}>
            <div className={styles.imagePlace}>
                {isLoading ? (
                    <div className={styles.skeletonImage}>
                        <Skeleton.Node active={true} style={{width:'100%', height:"100%" }} />    
                    </div>
                ) : (
                <Image.PreviewGroup
                    items={car?.images?.map((image) => `${baseUrl}${image}`) ?? []}
                >
                    <Image 
                        src={`${baseUrl}${car?.images[0]}`} 
                        alt="car"
                    />
                </Image.PreviewGroup>
                )}
            </div>
            <CarDetailsNames id={id}  />
        </div>
    )
})